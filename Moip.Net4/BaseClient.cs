using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Collections.Generic;
using Moip.Net4.OAuth;

namespace Moip.Net4
{

    public abstract class BaseApiCaller
    {
        #region Properties
        protected Uri ApiUri;
        private const string UserAgent = "SDK.Moip.v0.0.1";
        private Encoding encoding = Encoding.UTF8;
        #endregion

        #region JsonSerializerSettings
        protected Newtonsoft.Json.JsonSerializerSettings JsonSettings
        {
            get
            {
                return new JsonSerializerSettings()
                {
                    DateFormatString = "yyyy-MM-dd"
                };
            }
        }

        protected string ToJson(object item)
        {
            return JsonConvert.SerializeObject(item, JsonSettings);

        }

        protected T FromJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, JsonSettings);
        }
        #endregion

        protected virtual HttpClient CreateRequest()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", GetAuthorizationHeader());
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        private void TratarRetornoSemSucesso(HttpResponseMessage httpResponse)
        {
            if (httpResponse.StatusCode == HttpStatusCode.Unauthorized)
                throw new MoipException("APIKey ou Token inválidos.", httpResponse.StatusCode);

            var jsonResult = httpResponse.Content.ReadAsStringAsync().Result;

            var responseError = FromJson<ResponseError>(jsonResult);
            throw new MoipException(responseError.FullMessage, httpResponse.StatusCode, responseError);
        }


        #region POST
        protected async Task<HttpResponseMessage> DoPostVoidAsync<REQ>(Uri uri, REQ body)
        {
            HttpClient req = CreateRequest();
            try
            {
                HttpContent abodyEnvio = new StringContent(ToJson(body), Encoding.UTF8, "application/json");
                var retorno = await req.PostAsync(uri, abodyEnvio);
                if (!retorno.IsSuccessStatusCode)
                    TratarRetornoSemSucesso(retorno);

                return retorno;
            }
            catch (Exception exception)
            {
                throw;
            }
        }


        protected async Task<RES> DoPostAsync<REQ, RES>(Uri uri, REQ body)
        {

            try
            {
                var retorno = await DoPostVoidAsync(uri, body);

                var retornoJson = await retorno.Content.ReadAsStringAsync();
                return FromJson<RES>(retornoJson);
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        protected RES DoPost<REQ, RES>(Uri uri, REQ body)
        {
            return DoPostAsync<REQ, RES>(uri, body).Result;
        }

        protected HttpResponseMessage DoPostVoid<REQ>(Uri uri, REQ body)
        {
            return DoPostVoidAsync(uri, body).Result;
        }

        protected async Task<RES> DoPostFormUrlEncodedAsync<RES>(Uri uri, List<KeyValuePair<string, string>> body)
        {

            try
            {
                HttpClient req = CreateRequest();
                try
                {
                    HttpContent abodyEnvio = new FormUrlEncodedContent(body);
                    var retorno = await req.PostAsync(uri, abodyEnvio);
                    if (!retorno.IsSuccessStatusCode)
                        TratarRetornoSemSucesso(retorno);

                    var retornoJson = await retorno.Content.ReadAsStringAsync();
                    return FromJson<RES>(retornoJson);
                }
                catch (Exception exception)
                {
                    throw;
                }
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        protected RES DoPostFormUrlEncoded<RES>(Uri uri, List<KeyValuePair<string, string>> body)
        {
            return DoPostFormUrlEncodedAsync<RES>(uri, body).Result;
        }



        #endregion



        #region GET
        protected async Task<RES> DoGetAsync<RES>(Uri uri)
        {
            HttpClient req = CreateRequest();

            try
            {
                var retorno = await req.GetAsync(uri);
                if (!retorno.IsSuccessStatusCode)
                    TratarRetornoSemSucesso(retorno);

                var retornoJson = await retorno.Content.ReadAsStringAsync();
                return FromJson<RES>(retornoJson);
            }
            catch (Exception exception)
            {
                throw;
            }
        }
        protected RES DoGet<RES>(Uri uri)
        {
            return DoGetAsync<RES>(uri).Result;
        }
        #endregion

        #region DELETE
        protected async Task<HttpResponseMessage> DoDeleteAsync(Uri uri)
        {
            HttpClient req = CreateRequest();

            try
            {
                var retorno = await req.GetAsync(uri);
                if (!retorno.IsSuccessStatusCode)
                    TratarRetornoSemSucesso(retorno);

                return retorno;
            }
            catch (Exception exception)
            {
                throw;
            }
        }
        protected HttpResponseMessage DoDelete(Uri uri)
        {
            return DoDeleteAsync(uri).Result;
        }
        #endregion

        protected abstract string GetAuthorizationHeader();


    }
    public abstract class OauthAutenticationApiCaller : BaseApiCaller
    {
        protected GenerateTokenResponse Token;

        protected OauthAutenticationApiCaller(Uri apiUri, GenerateTokenResponse token)
        {

            ApiUri = apiUri;
            Token = token;
        }

        protected override string GetAuthorizationHeader()
        {
            return string.Format("OAuth {0}", Token.Access_token);

        }
    }


    public abstract class BasicAutenticationApiCaller : BaseApiCaller
    {
        protected string ApiToken;
        protected string ApiKey;

        protected BasicAutenticationApiCaller(Uri apiUri, string apiToken, string apiKey)
        {
            ApiUri = apiUri;
            ApiToken = apiToken;
            ApiKey = apiKey;
        }




        protected override string GetAuthorizationHeader()
        {
            var base64Key = Convert.ToBase64String(Encoding.Default.GetBytes(string.Format("{0}:{1}", ApiToken, ApiKey)));
            return string.Format("Basic {0}", base64Key);
        }





    }


}

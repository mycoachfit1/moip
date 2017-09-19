using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Moip.Net4.OAuth
{
    public class OAuthAPI : BasicAutenticationApiCaller
    {
        public OAuthAPI(Uri apiUri, string apiToken, string apiKey) : base(apiUri, apiToken, apiKey)
        {
        }

        /// <summary>
        /// Com a permissão concedida, você receberá um code que lhe permitira recuperar o accessToken de autenticação e processar requisições envolvendo outro usuário. Seguindo a especificação do <see href="https://tools.ietf.org/html/rfc6749"> OAuth 2.0 Authorization Framework </see> esse request é feita com os atributos em x-www-form-urlencoded, ao invés de um JSON.
        /// </summary>
        /// <param name="client_id">string(4), obrigatório. Identificador único do aplicativo que está realizando a solicitação. No formato APP-XXXXXXXXXXXX</param>
        /// <param name="client_secret">string(32) obrigatório. Chave privada do aplicativo. O atributo secret que foi enviado na criação do seu aplicativo </param>
        /// <param name="code">string(32) obrigatório Código de validação para recuperar o token de acesso. O code retornado para a URL cadastrada quando o usuário dá autorização de permissão</param>
        /// <param name="redirect_uri">string obrigatório URL de redirecionamento do cliente (deve ser a mesma utilizada na ação de solicitação de permissão).</param>
        /// <returns></returns>
        public GenerateTokenResponse GenerateToken(string client_id, string client_secret, string code, string redirect_uri)
        {
            var listaVariaveis = new List<KeyValuePair<string, string>>();
            listaVariaveis.Add(new KeyValuePair<string, string>("client_id", client_id));
            listaVariaveis.Add(new KeyValuePair<string, string>("client_secret", client_secret));
            listaVariaveis.Add(new KeyValuePair<string, string>("code", code));
            listaVariaveis.Add(new KeyValuePair<string, string>("redirect_uri", redirect_uri));
            return DoPostFormUrlEncoded<GenerateTokenResponse>(new Uri(ApiUri, $"oauth/token"), listaVariaveis);
        }

        /// <summary>
        /// Com a permissão concedida, você receberá um code que lhe permitira recuperar o accessToken de autenticação e processar requisições envolvendo outro usuário. Seguindo a especificação do <see href="https://tools.ietf.org/html/rfc6749"> OAuth 2.0 Authorization Framework </see> esse request é feita com os atributos em x-www-form-urlencoded, ao invés de um JSON.
        /// </summary>
        /// <param name="client_id">string(4), obrigatório. Identificador único do aplicativo que está realizando a solicitação. No formato APP-XXXXXXXXXXXX</param>
        /// <param name="client_secret">string(32) obrigatório. Chave privada do aplicativo. O atributo secret que foi enviado na criação do seu aplicativo </param>
        /// <param name="code">string(32) obrigatório Código de validação para recuperar o token de acesso. O code retornado para a URL cadastrada quando o usuário dá autorização de permissão</param>
        /// <param name="redirect_uri">string obrigatório URL de redirecionamento do cliente (deve ser a mesma utilizada na ação de solicitação de permissão).</param>
        /// <returns></returns>
        public async Task<GenerateTokenResponse> GenerateTokenAsync(string client_id, string client_secret, string code, string redirect_uri)
        {
            var listaVariaveis = new List<KeyValuePair<string, string>>();
            listaVariaveis.Add(new KeyValuePair<string, string>("client_id", client_id));
            listaVariaveis.Add(new KeyValuePair<string, string>("client_secret", client_secret));
            listaVariaveis.Add(new KeyValuePair<string, string>("code", code));
            listaVariaveis.Add(new KeyValuePair<string, string>("redirect_uri", redirect_uri));
            return await DoPostFormUrlEncodedAsync<GenerateTokenResponse>(new Uri(ApiUri, $"oauth/token"), listaVariaveis);
        }

    }
}

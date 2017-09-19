using System;
using System.Threading.Tasks;

namespace Moip.Net4
{
    public sealed class CustomersApi : BasicAutenticationApiCaller
    {
        public CustomersApi(Uri apiUri, string apiToken, string apiKey) : base(apiUri, apiToken, apiKey)
        {

        }


        /// <summary>
        /// Chamada Sincrona da API <see href="https://dev.moip.com.br/v2.0/reference#adicionar-cartao-de-credito">Adicionar um cartão de crédito</see> 
        /// </summary>
        /// <param name="idCustomer">Id do Cliente no Moip</param>
        /// <param name="req"></param>
        /// <returns></returns>
        public CreditCardAddCreditCardResponse AddCreditCard(string idCustomer, AddCreditCardRequest req)
        {
            return DoPost<AddCreditCardRequest, CreditCardAddCreditCardResponse>(new Uri(ApiUri, $"v2/customers/{idCustomer}/fundinginstruments"), req);
        }

        /// <summary>
        /// Chamada Assincrona da API <see href="https://dev.moip.com.br/v2.0/reference#adicionar-cartao-de-credito">Adicionar um cartão de crédito</see> 
        /// </summary>
        /// <param name="idCustomer">Id do Cliente no Moip</param>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<CreditCardAddCreditCardResponse> AddCreditCardAsync(string idCustomer, AddCreditCardRequest req)
        {
            return await DoPostAsync<AddCreditCardRequest, CreditCardAddCreditCardResponse>(new Uri(ApiUri, $"v2/customers/{idCustomer}/fundinginstruments"), req);
        }

        /// <summary>
        /// Chamada Sincrona da API <see href="https://dev.moip.com.br/v2.0/reference#criar-um-cliente">Criar um cliente </see> 
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public CreateCustomersResponse CreateCustomer(CreateCustomersRequest req)
        {
            return DoPost<CreateCustomersRequest, CreateCustomersResponse>(new Uri(ApiUri, "v2/customers"), req);
        }

        /// <summary>
        /// Chamada Assincrona da API <see href="https://dev.moip.com.br/v2.0/reference#criar-um-cliente">Criar um cliente</see> 
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<CreateCustomersResponse> CreateCustomerAsync(CreateCustomersRequest req)
        {
            return await DoPostAsync<CreateCustomersRequest, CreateCustomersResponse>(new Uri(ApiUri, "v2/customers"), req);
        }

        /// <summary>
        /// Chamada Sincrona da API <see href="https://dev.moip.com.br/v2.0/reference#deletar-cartão-de-crédito">Deletar um cartão de crédito</see> 
        /// </summary>
        /// <param name="idCreditCard"></param>
        /// <returns></returns>
        public System.Net.Http.HttpResponseMessage DeleteCreditCard(string idCreditCard)
        {
            return DoDelete(new Uri(ApiUri, $"v2/fundinginstruments/{idCreditCard}"));
        }

        /// <summary>
        /// Chamada Assincrona da API <see href="https://dev.moip.com.br/v2.0/reference#deletar-cartão-de-crédito">Deletar um cartão de crédito</see> 
        /// </summary>
        /// <param name="idCreditCard"></param>
        /// <returns></returns>
        public async Task<System.Net.Http.HttpResponseMessage> DeleteCreditCardAsync(string idCreditCard)
        {
            return await DoDeleteAsync(new Uri(ApiUri, $"v2/fundinginstruments/{idCreditCard}"));
        }


        /// <summary>
        /// Chamada Sincrona da API <see href="https://dev.moip.com.br/v2.0/reference#consultar-um-cliente">Consultar um cliente </see> 
        /// </summary>
        /// <param name="idCustomer">Id do Cliente no Moip</param>
        /// <returns></returns>
        public CreateCustomersResponse GetCustomer(string idCustomer)
        {
            return DoGet<CreateCustomersResponse>(new Uri(ApiUri, $"v2/customers/{idCustomer}"));
        }

        /// <summary>
        /// Chamada Assincrona da API <see href="https://dev.moip.com.br/v2.0/reference#consultar-um-cliente">Consultar um cliente</see> 
        /// </summary>
        /// <param name="idCustomer">Id do Cliente no Moip</param>
        /// <returns></returns>
        public async Task<CreateCustomersResponse> GetCustomerAsync(string idCustomer)
        {
            return await DoGetAsync<CreateCustomersResponse>(new Uri(ApiUri, $"v2/customers/{idCustomer}"));
        }

    }



}

using System;
using System.Threading.Tasks;

namespace Moip.Net4
{
    public sealed class OrdersApi : BasicAutenticationApiCaller
    {
        public OrdersApi(Uri apiUri, string apiToken, string apiKey) : base(apiUri, apiToken, apiKey)
        {
        }

        /// <summary>
        /// Chamada Sincrona da API <see href="https://dev.moip.com.br/v2.0/reference#criar-pedido">Criar um Pedido</see> 
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public CreateOrdersResponse CreateOrder(CreateOrdersRequest req)
        {
            return DoPost<CreateOrdersRequest, CreateOrdersResponse>(new Uri(ApiUri, "v2/orders"), req);
        }

        /// <summary>
        /// Chamada Assincrona da API <see href="https://dev.moip.com.br/v2.0/reference#criar-pedido">Criar um Pedido</see> 
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<CreateOrdersResponse> CreateOrderAsync(CreateOrdersRequest req)
        {
            return await DoPostAsync<CreateOrdersRequest, CreateOrdersResponse>(new Uri(ApiUri, "v2/orders"), req);
        }

        /// <summary>
        /// Chamada Sincrona da API <see href="https://dev.moip.com.br/v2.0/reference#consultar-pedido">Consultar Pedido</see> 
        /// </summary>
        /// <param name="IdOrder"></param>
        /// <returns></returns>
        public GetOrderResponse GetOrder(string IdOrder)
        {
            return DoGet<GetOrderResponse>(new Uri(ApiUri, $"v2/orders/{IdOrder}"));
        }

        /// <summary>
        /// Chamada Assincrona da API <see href="https://dev.moip.com.br/v2.0/reference#consultar-pedido">Consultar Pedido</see> 
        /// </summary>
        /// <param name="IdOrder"></param>
        /// <returns></returns>
        public async Task<GetOrderResponse> GetOrderAsync(string IdOrder)
        {
            return await DoGetAsync<GetOrderResponse>(new Uri(ApiUri, $"v2/orders/{IdOrder}"));
        }

    }

}

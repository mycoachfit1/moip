namespace MoipClient
{
    public class OrderItemCreateOrdersRequest
    {
        [Newtonsoft.Json.JsonProperty("product")]
        public string Product { get; set; }
        [Newtonsoft.Json.JsonProperty("quantity")]
        public int Quantity { get; set; }
        [Newtonsoft.Json.JsonProperty("detail")]
        public string Detail { get; set; }
        /// <summary>
        ///REQUIRED Valor inicial do item. (O valor será multiplicado de acordo com a quantidade de items.) Em centavos Ex: R$10,32 deve ser informado 1032 integer(12)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        public int Price { get; set; }
    }

}

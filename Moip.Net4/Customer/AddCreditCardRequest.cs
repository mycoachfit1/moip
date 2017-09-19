namespace Moip.Net4
{
    public class AddCreditCardRequest
    {
        /// <summary>
        /// Método do instrumento de cobrança. Valores possíveis: CREDIT_CARD
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [Newtonsoft.Json.JsonProperty("method")]
        public MethodType Method { get; set; }

        [Newtonsoft.Json.JsonProperty("creditCard")]
        public CreditCardAddCreditCardRequest CreditCard { get; set; }
    }



}

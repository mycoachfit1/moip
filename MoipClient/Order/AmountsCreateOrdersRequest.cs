namespace MoipClient
{
    public class AmountsCreateOrdersRequest
    {
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [Newtonsoft.Json.JsonProperty("currency")]
        public CurrencyType? Currency { get; set; }
        [Newtonsoft.Json.JsonProperty("subtotals")]
        public TotaisAmountsCreateOrdersRequest Subtotals { get; set; }
    }

}

namespace MoipClient
{
    public class TotaisAmountsCreateOrdersRequest
    {
        [Newtonsoft.Json.JsonProperty("shipping")]
        public decimal? Shipping { get; set; }

        [Newtonsoft.Json.JsonProperty("addition")]
        public decimal? addition { get; set; }

        [Newtonsoft.Json.JsonProperty("discount")]
        public decimal? discount { get; set; }


    }

}

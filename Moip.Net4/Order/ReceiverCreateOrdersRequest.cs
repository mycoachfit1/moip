namespace Moip.Net4
{
    public class ReceiverCreateOrdersRequest
    {
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [Newtonsoft.Json.JsonProperty("type")]
        public ReceiverType? Type { get; set; }
        [Newtonsoft.Json.JsonProperty("feePayor")]
        public bool FeePayor { get; set; }
        [Newtonsoft.Json.JsonProperty("moipAccount")]
        public MoipAccountReceiverCreateOrdersRequest moipAccount { get; set; }
        [Newtonsoft.Json.JsonProperty("amount")]
        public AmountReceiverCreateOrdersRequest Amount { get; set; }
    }

}

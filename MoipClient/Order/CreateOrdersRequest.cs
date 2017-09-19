using System.Collections.Generic;

namespace MoipClient
{
    public class CreateOrdersRequest
    {
        [Newtonsoft.Json.JsonProperty("ownId")]
        public string OwnId { get; set; }
        [Newtonsoft.Json.JsonProperty("amount")]
        public AmountsCreateOrdersRequest Amount { get; set; }
        [Newtonsoft.Json.JsonProperty("items")]
        public List<OrderItemCreateOrdersRequest> Items { get; set; }
        [Newtonsoft.Json.JsonProperty("customer")]
        public ClienteCreateOrdersRequest Customer { get; set; }
        [Newtonsoft.Json.JsonProperty("receivers")]
        public List<ReceiverCreateOrdersRequest> Receivers { get; set; }
    }

}

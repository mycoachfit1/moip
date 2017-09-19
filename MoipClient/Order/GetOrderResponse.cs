using System;
using System.Collections.Generic;

namespace MoipClient
{
    public class GetOrderResponse
    {
        public string Id { get; set; }
        public string OwnId { get; set; }
        public OrderStatusType? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public TotaisAmountsCreateOrdersResponse Amount { get; set; }
        public List<OrderItemCreateOrdersResponse> Items { get; set; }
        public ClienteCreateOrdersResponse Customer { get; set; }
        public List<OrderEvent> Events { get; set; }
        public AddressDto ShippingAddress { get; set; }
        public List<ReceiverCreateOrdersResponse> Receivers { get; set; }


        public LinksCreateOrdersResponse _links { get; set; }
    }

}

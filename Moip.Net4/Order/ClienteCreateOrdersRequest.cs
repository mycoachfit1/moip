namespace Moip.Net4
{
    public class ClienteCreateOrdersRequest
    {
        public ClienteCreateOrdersRequest(string id )
        {
            Id = id;
        }
        public ClienteCreateOrdersRequest()
        {

        }

        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }
        [Newtonsoft.Json.JsonProperty("ownId")]
        public string OwnId { get; set; }
        [Newtonsoft.Json.JsonProperty("fullname")]
        public string Fullname { get; set; }
        [Newtonsoft.Json.JsonProperty("email")]
        public string Email { get; set; }
        [Newtonsoft.Json.JsonProperty("birthDate")]
        public string BirthDate { get; set; }
        public PhoneDto Phone { get; set; }
        public DocumentDto TaxDocument { get; set; }
        public AddressDto ShippingAddress { get; set; }
    }

}

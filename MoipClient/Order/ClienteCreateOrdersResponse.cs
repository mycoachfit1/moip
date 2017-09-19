namespace MoipClient
{
    public class ClienteCreateOrdersResponse
    {
        public string OwnId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public MoipAccountClienteCreateOrdersResponse moipAccount { get; set; }
        public LinksClienteCreateOrdersResponse _links { get; set; }
        public PhoneDto Phone { get; set; }
        public DocumentDto TaxDocument { get; set; }
        public AddressDto ShippingAddress { get; set; }
    }

}

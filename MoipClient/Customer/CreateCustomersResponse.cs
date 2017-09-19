namespace MoipClient
{
    public class CreateCustomersResponse
    {
        public string Id { get; set; }
        public string OwnId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public PhoneDto Phone { get; set; }
        public string BirthDate { get; set; }
        public DocumentDto TaxDocument { get; set; }
        public AddressDto ShippingAddress { get; set; }

        public override string ToString()
        {
            return OwnId;
        }

    }



}

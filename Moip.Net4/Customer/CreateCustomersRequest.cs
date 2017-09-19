using System;

namespace Moip.Net4
{
    public class CreateCustomersRequest
    {
        /// <summary>
        /// REQUIRED
        /// Id próprio do cliente.Referência externa.Limite de caracteres: (65).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ownId")]
        public string OwnId { get; set; }
        /// <summary>
        /// REQUIRED
        /// Nome completo do cliente.Limite de caracteres: (90)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullname")]
        public string Fullname { get; set; }
        /// <summary>
        /// REQUIRED
        /// Email do cliente. Limite de caracteres: (45)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        public string Email { get; set; }

        [Newtonsoft.Json.JsonProperty("phone")]
        public PhoneDto Phone { get; set; }

        /// <summary>
        /// Data de nascimento do cliente. date (AAAA-MM-DD)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birthDate")]
        public DateTime BirthDate { get; set; }


        [Newtonsoft.Json.JsonProperty("taxDocument")]
        public DocumentDto TaxDocument { get; set; }

        [Newtonsoft.Json.JsonProperty("shippingAddress")]
        public AddressDto ShippingAddress { get; set; }

        public override string ToString()
        {
            return OwnId;
        }

    }



}

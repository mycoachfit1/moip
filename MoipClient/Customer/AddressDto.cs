namespace MoipClient
{
    public class AddressDto
    {
        /// <summary>
        /// REQUIRED Logradouro do endereço
        /// </summary>
        [Newtonsoft.Json.JsonProperty("street")]
        public string Street { get; set; }
        /// <summary>
        /// REQUIRED Número
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetNumber")]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Complemento do endereço.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complement")]
        public string Complement { get; set; }
        /// <summary>
        /// REQUIRED Bairro
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district")]
        public string District { get; set; }
        /// <summary>
        /// REQUIRED Cidade
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        /// REQUIRED Estado
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        public string State { get; set; }
        /// <summary>
        /// REQUIRED País em formato ISO-alpha3, exemplo BRA.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("country")]
        public string Country { get; set; }
        /// <summary>
        /// REQUIRED O CEP do endereço de cobrança
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zipCode")]
        public string ZipCode { get; set; }
    }



}

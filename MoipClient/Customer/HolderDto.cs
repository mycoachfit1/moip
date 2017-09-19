namespace MoipClient
{
    public class HolderDto
    {
        /// <summary>
        /// Nome do portador impresso no cartão. string(90),
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullname")]
        public string Fullname { get; set; }
        /// <summary>
        /// Data de nascimento do cliente. date(AAAA-MM-DD),
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birthdate")]
        public System.DateTime Birthdate { get; set; }
        [Newtonsoft.Json.JsonProperty("phone")]
        public PhoneDto Phone { get; set; }
        [Newtonsoft.Json.JsonProperty("taxDocument")]
        public DocumentDto TaxDocument { get; set; }
    }



}

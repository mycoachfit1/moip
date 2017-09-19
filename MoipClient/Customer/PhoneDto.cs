namespace MoipClient
{
    public class PhoneDto
    {
        /// <summary>
        /// REQUIRED
        /// DDI (código internacional) do telefone. Valores possíveis: 55. Limite de caracteres: 2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("countryCode")]
        public int CountryCode { get; set; }
        /// <summary>
        /// REQUIRED
        /// Código de área do cliente. Limite de caracteres: (2)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("areaCode")]
        public int AreaCode { get; set; }
        /// <summary>
        /// REQUIRED
        /// Número de telefone do cliente. Limite de caracteres: 9
        /// </summary>
        [Newtonsoft.Json.JsonProperty("number")]
        public int Number { get; set; }
    }



}

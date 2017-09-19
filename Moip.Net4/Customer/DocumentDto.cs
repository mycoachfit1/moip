namespace Moip.Net4
{
    public class DocumentDto
    {
        /// <summary>
        /// REQUIRED Tipo do documento. Valores possíveis: CPF, CNPJ. Limite de caracteres: (4)
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [Newtonsoft.Json.JsonProperty("type")]
        public DocumentType Type { get; set; }
        /// <summary>
        /// REQUIRED Número do documento. Limite de caracteres: (11)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("number")]
        public string Number { get; set; }
    }



}

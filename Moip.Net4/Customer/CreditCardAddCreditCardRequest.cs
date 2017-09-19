namespace Moip.Net4
{
    public class CreditCardAddCreditCardRequest
    {
        public string Id { get; set; }

        /// <summary>
        /// Número do cartão de crédito. (Necessário estar dentro do escopo PCI para enviar esse campo sem criptografia) string(19)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Mês de expiração do cartão. (Necessário estar dentro do escopo PCI para enviar esse campo sem criptografia) integer(2)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expirationMonth")]
        public int? ExpirationMonth { get; set; }
        /// <summary>
        /// Ano de expiração do cartão. (Necessário estar dentro do escopo PCI para enviar esse campo sem criptografia) integer(4)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expirationYear")]
        public int? ExpirationYear { get; set; }

        /// <summary>
        /// Código de segurança do cartão. (Necessário estar dentro do escopo PCI para enviar esse campo sem criptografia)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cvc")]
        public int? Cvc { get; set; }

        [Newtonsoft.Json.JsonProperty("holder")]
        public HolderDto Holder { get; set; }

    }



}

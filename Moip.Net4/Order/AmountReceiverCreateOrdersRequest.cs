namespace Moip.Net4
{
    public class AmountReceiverCreateOrdersRequest
    {
        [Newtonsoft.Json.JsonProperty("percentual")]
        public int Percentual { get; set; }

        /// <summary>
        /// Valor fixo a ser recebido. Em centavos Ex: R$10,32 deve ser informado 1032 integer(12)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fixed")]
        public int ValueFixed { get; set; }

    }

}

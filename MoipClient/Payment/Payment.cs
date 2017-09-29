using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoipClient
{
    public class PaymentAPI : BasicAutenticationApiCaller
    {
        public PaymentAPI(Uri apiUri, string apiToken, string apiKey) : base(apiUri, apiToken, apiKey)
        {
        }



        public CreatePaymentResponse CreatePayment(string idOrder, CreatePaymentRequest req)
        {
            return DoPost<CreatePaymentRequest, CreatePaymentResponse>(new Uri(ApiUri, $"v2/orders/{idOrder}/payments"), req);
        }

        public async Task<CreatePaymentResponse> CreatePaymentAsync(string idOrder, CreatePaymentRequest req)
        {
            return await DoPostAsync<CreatePaymentRequest, CreatePaymentResponse>(new Uri(ApiUri, $"v2/orders/{idOrder}/payments"), req);
        }

        /// <summary>
        /// Por meio desta API é possível consultar as informações e detalhes de um Pagamento em específico.
        /// </summary>
        /// <param name="idPayment">REQUIRED id do pagamento em formato de hash string (16)
        /// </param>
        /// <returns></returns>
        public CreatePaymentResponse GetPayment(string idPayment)
        {
            return DoGet<CreatePaymentResponse>(new Uri(ApiUri, $"v2/payments/{idPayment}"));
        }

        /// <summary>
        /// Por meio desta API é possível consultar as informações e detalhes de um Pagamento em específico.
        /// </summary>
        /// <param name="idPayment"> REQUIRED id do pagamento em formato de hash string (16)</param>
        /// <returns></returns>
        public async Task<CreatePaymentResponse> GetPaymentAsync(string idPayment)
        {
            return await DoGetAsync<CreatePaymentResponse>(new Uri(ApiUri, $"v2/payments/{idPayment}"));
        }

    }

    public class AmountCreatePaymentResponse
    {
        public decimal? Total { get; set; }
        public decimal? Fees { get; set; }
        public decimal? Refunds { get; set; }
        public decimal? Liquid { get; set; }
        public CurrencyType? Currency { get; set; }
    }
    public class CreditCardFundingInstrumentCreatePaymentResponse
    {
        public string Id { get; set; }
        public BrandType Brand { get; set; }
        public string First6 { get; set; }
        public string Last4 { get; set; }
        public HolderDto Holder { get; set; }
    }


    public class FundingInstrumentCreatePaymentResponse
    {
        public MethodType Method { get; set; }
        public CreditCardFundingInstrumentCreatePaymentResponse CreditCard { get; set; }
    }
    public class FeesCreatePaymentResponse
    {
        public FeeType Type { get; set; }
        public int Amount { get; set; }
    }
    public class EventoCreatePaymentResponse
    {
        public DateTime CreatedAt { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
    public class OrderLinksCreatePaymentResponse
    {
        public string Title { get; set; }
        public string Href { get; set; }
    }

    public class LinksCreatePaymentResponse
    {
        public SelfLinksClienteCreateOrdersResponse Self { get; set; }
        public OrderLinksCreatePaymentResponse Order { get; set; }
    }
    public class CreatePaymentResponse
    {
        public string Id { get; set; }
        public PaymentStatusType? Status { get; set; }
        public int InstallmentCount { get; set; }
        public AmountCreatePaymentResponse Amount { get; set; }
        public bool? DelayCapture { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }

        public FundingInstrumentCreatePaymentResponse FundingInstrument { get; set; }
        public List<FeesCreatePaymentResponse> Fees { get; set; }

        public List<EventoCreatePaymentResponse> Events { get; set; }

        public DeviceCreatePaymentRequest Device { get; set; }

        public LinksCreatePaymentResponse _links { get; set; }
    }

    public abstract class FundingInstrumentCreatePaymentRequest
    {
        [Newtonsoft.Json.JsonProperty("method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public abstract MethodType Method { get; }
        //public Boleto Boleto { get; set; }
        //public DebitoOnline OnlineDebit { get; set; }
        //public ContaBancaria BankAccount { get; set; }

    }

   

    public class FundingInstrumentCreditCard : FundingInstrumentCreatePaymentRequest
    {
        [Newtonsoft.Json.JsonProperty("method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public override MethodType Method { get { return MethodType.CREDIT_CARD; } }
        [Newtonsoft.Json.JsonProperty("creditCard")]
        public CreditCardAddCreditCardRequest CreditCard { get; set; }
    }


    public class GeolocationDeviceCreatePaymentRequest
    {
        /// <summary>
        /// Latitude da localização do comprador. Valores possíveis vão de -90 até 90, com 7 decimais.
        /// </summary>
        public decimal latitude { get; set; }

        /// <summary>
        /// Longitude  da localização do comprador. Valores possíveis vão de -90 até 90, com 7 decimais.
        /// </summary>
        public decimal longitude { get; set; }
    }

    public class DeviceCreatePaymentRequest
    {
        /// <summary>
        /// IP do comprador.
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// Informações do software utilizado pelo comprador, como sistema operacional e navegador.
        /// </summary>
        public string UserAgent { get; set; }

        public GeolocationDeviceCreatePaymentRequest Geolocation { get; set; }
        /// <summary>
        /// Fingerprint do device utilizado. Para uso do device.fingerprint, recomendamos bibliotecas baseadas em Canvas Fingerprints. 
        /// </summary>
        public string Fingerprint { get; set; }


    }
    public class CreatePaymentRequest
    {
        /// <summary>
        /// Número de parcelas. Válido para pagamentos por cartão. Se não for informado, o pagamento será realizado em 1 parcela. Mínimo 1 e Máximo 12.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("installmentCount")]
        public int InstallmentCount { get; set; }

        /// <summary>
        /// Identificação de sua loja na fatura de cartão de crédito do comprador. string(13)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statementDescriptor")]
        public string StatementDescriptor { get; set; }
        /// <summary>
        /// Se o pagamento deve ser pré-autorizado para captura posterior. Válido apenas para pagamentos por cartão de crédito.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delayCapture")]
        public bool? DelayCapture { get; set; }

        [Newtonsoft.Json.JsonProperty("fundingInstrument")]
        public FundingInstrumentCreatePaymentRequest FundingInstrument { get; set; }
        public DeviceCreatePaymentRequest Device { get; set; }




    }

}

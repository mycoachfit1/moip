using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moip.Net4
{
    public class PaymentAPI : BasicAutenticationApiCaller
    {
        public PaymentAPI(Uri apiUri, string apiToken, string apiKey) : base(apiUri, apiToken, apiKey)
        {
        }



        public CreatePaymentResponse CreatePayment(string idOrder, CreatePaymentRequest req)
        {
            return DoPost<CreatePaymentRequest, CreatePaymentResponse>(new Uri($"v2/orders/{idOrder}/payments"), req);
        }

        public async Task<CreatePaymentResponse> CreatePaymentAsync(string idOrder, CreatePaymentRequest req)
        {
            return await DoPostAsync<CreatePaymentRequest, CreatePaymentResponse>(new Uri($"v2/orders/{idOrder}/payments"), req);
        }

        /// <summary>
        /// Por meio desta API é possível consultar as informações e detalhes de um Pagamento em específico.
        /// </summary>
        /// <param name="idPayment">REQUIRED id do pagamento em formato de hash string (16)
        /// </param>
        /// <returns></returns>
        public CreatePaymentResponse GetPayment(string idPayment)
        {
            return DoGet<CreatePaymentResponse>(new Uri($"v2/payments/{idPayment}"));
        }

        /// <summary>
        /// Por meio desta API é possível consultar as informações e detalhes de um Pagamento em específico.
        /// </summary>
        /// <param name="idPayment"> REQUIRED id do pagamento em formato de hash string (16)</param>
        /// <returns></returns>
        public async Task<CreatePaymentResponse> GetPaymentAsync(string idPayment)
        {
            return await DoGetAsync<CreatePaymentResponse>(new Uri($"v2/payments/{idPayment}"));
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
        public abstract MethodType Method { get; }
        //public Boleto Boleto { get; set; }
        //public DebitoOnline OnlineDebit { get; set; }
        //public ContaBancaria BankAccount { get; set; }

    }

    public class CreditCardFundingInstrumentCreditCard
    {
        /// <summary>
        /// Identificador do cartão de crédito no previamente salvo no Moip. string(16)
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Dados criptografados do cartão de crédito
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Determina durante a criação de um pagamento se o cartão de crédito utilizado deve ser salvo para oneClickBuy (default: true).l
        /// </summary>
        public bool Store { get; set; }

        public HolderDto Holder { get; set; }
    }


    public class FundingInstrumentCreditCard : FundingInstrumentCreatePaymentRequest
    {
        public override MethodType Method { get { return MethodType.CREDIT_CARD; } }
        public CreditCardFundingInstrumentCreditCard CreditCard { get; set; }
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
        public int InstallmentCount { get; set; }
        public string StatementDescriptor { get; set; }
        public bool? DelayCapture { get; set; }

        public FundingInstrumentCreatePaymentRequest FundingInstrument { get; set; }
        public DeviceCreatePaymentRequest Device { get; set; }




    }

}

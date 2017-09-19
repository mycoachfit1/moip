namespace Moip.Net4
{
    public class CheckoutMoipLinksCreateOrdersResponse
    {
        public HostedAccountLinksClienteCreateOrdersResponse PayCheckout { get; set; }
        public HostedAccountLinksClienteCreateOrdersResponse PayCreditCard { get; set; }
        public HostedAccountLinksClienteCreateOrdersResponse PayBoleto { get; set; }
        public HostedAccountLinksClienteCreateOrdersResponse PayOnlineBankDebitItau { get; set; }
    }

}

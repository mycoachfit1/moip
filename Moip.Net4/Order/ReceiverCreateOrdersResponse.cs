namespace Moip.Net4
{
    public class ReceiverCreateOrdersResponse
    {
        public bool FeePayor { get; set; }
        public ReceiverType? Type { get; set; }
        public MoipAccountReceiverCreateOrdersResponse moipAccount { get; set; }
        public TotaisAmountsReceiverCreateOrdersResponse Amount { get; set; }
    }

}

namespace MoipClient
{
    public class TotaisAmountsCreateOrdersResponse
    {
        public decimal? Total { get; set; }
        public decimal? Fees { get; set; }
        public decimal? Refunds { get; set; }
        public decimal? Liquid { get; set; }
        public decimal? OtherReceivers { get; set; }
        public CurrencyType? Currency { get; set; }
        public SubTotaisTotaisAmountsCreateOrdersResponse Subtotals { get; set; }
    }

}

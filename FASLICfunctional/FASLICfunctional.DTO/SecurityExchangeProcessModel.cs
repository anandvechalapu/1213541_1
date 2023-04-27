namespace FASLICFunctional
{
    public class SecurityExchangeProcessModel
    {
        public int Id { get; set; } 
        public string ExchangeType { get; set; }
        public string ExchangeCounterparty { get; set; }
        public string ExchangeDate { get; set; }
        public string ExchangeCurrency { get; set; }
        public decimal ExchangeAmount { get; set; }
    }
}
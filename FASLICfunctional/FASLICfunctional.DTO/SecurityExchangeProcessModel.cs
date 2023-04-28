namespace FASLIC.Functional
{
    public class SecurityExchangeProcessModel
    {
        public Guid Id { get; set; }
        public string Source { get; set; }
        public DateTime Date { get; set; }
        public string Reference { get; set; }
        public string Type { get; set; }
    }
}
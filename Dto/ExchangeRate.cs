namespace projekt.Dto
{
    public class ExchangeRate: ExchangeRateInterface
    {
        public required string currency { get; set; }
        public required string code { get; set; }
        public required decimal mid { get; set; }
    }
}

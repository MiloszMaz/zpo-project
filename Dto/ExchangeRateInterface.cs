namespace projekt.Dto
{
    public interface ExchangeRateInterface
    {
        string currency { get; set; }
        string code { get; set; }
        decimal mid { get; set; }
    }
}

using projekt.Dto;

namespace projekt
{
    public class NbpService
    {
        private const string url = "http://api.nbp.pl/api/exchangerates/tables/A?format=json";

        public List<ExchangeRate> getExchangeRates()
        {
            List<ExchangeRate> list = new List<ExchangeRate>();

            list.Insert(0, new ExchangeRate
            {
                currency = "USD",
                code = "USD",
                mid = 4.5m
            });

            return list;
        }
    }
}

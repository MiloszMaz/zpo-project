using projekt.Dto;
using projekt.Services;

namespace projekt.Calculators
{
    class CurrencyCalculator
    {
        private readonly FileService _fileService = new FileService();
        private readonly List<ExchangeRate> rates;

        public CurrencyCalculator() 
        {
            List<ExchangeRate> list = _fileService.getFromFile();
            this.rates = list;
        }

        public decimal convert(string fromCode, string toCode, decimal amount)
        {
            var from = rates.FirstOrDefault(r => r.code == fromCode);
            var to = rates.FirstOrDefault(r => r.code == toCode);

            if (from == null || to == null)
            {
                throw new Exception("Nie znaleziono jednej z walut.");
            }

            decimal amountInPLN = amount * from.mid;

            return amountInPLN / to.mid;
        }
    }
}

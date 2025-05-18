using System.Net.Http.Json;
using projekt.Dto;
using projekt.Exceptions;

namespace projekt.Services
{
    public class NbpService
    {
        private const string url = "http://api.nbp.pl/api/exchangerates/tables/A?format=json";

        public List<ExchangeRate> getExchangeRates()
        {
            try
            {
                var client = new HttpClient();
                var response = client.GetFromJsonAsync<List<NbpResponseDto>>(url).Result;

                return response?[0].Rates ?? new List<ExchangeRate>();
            }
            catch (Exception ex)
            {
                throw new ApiException("API Error: " + ex.Message);
            }
        }
    }
}

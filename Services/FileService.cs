using System.Text.Json;
using projekt.Dto;
using projekt.Exceptions;

namespace projekt.Services
{
    public class FileService
    {
        private readonly ConfigService _configService = new ConfigService();

        public void save(List<ExchangeRate> list)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(list);

                File.WriteAllText(this.getOutputFilePath(), jsonString);
            } catch(Exception exception) {
                throw new FileException("Error on save data: " + exception.Message);
            }
        }

        public List<ExchangeRate> getFromFile()
        {
            try
            {
                string outputFilePath = this.getOutputFilePath();

                if (!File.Exists(outputFilePath)) {
                    return new List<ExchangeRate>();
                }

                var json = File.ReadAllText(outputFilePath);

                return JsonSerializer.Deserialize<List<ExchangeRate>>(json) ?? new List<ExchangeRate>();
            }
            catch (Exception exception)
            {
                throw new Exception("Error on get list data: " + exception.Message);
            }
        }

        private string getOutputFilePath()
        {
            return Path.Combine(this.getRootPath(), _configService.getOutputFilePath());
        }

        private string getRootPath()
        {
            var basePath = AppContext.BaseDirectory;

            return Path.GetFullPath(Path.Combine(basePath, @"..\..\.."));
        }
    }
}

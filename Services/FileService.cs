using System.Text.Json;
using projekt.Dto;

namespace projekt.Services
{
    public class FileService
    {
        private readonly ConfigService _configService = new ConfigService();

        public void save(List<ExchangeRate> list)
        {
            string jsonString = JsonSerializer.Serialize(list);

            string outputPath = Path.Combine(this.getRootPath(), _configService.getOutputFilePath());

            File.WriteAllText(outputPath, jsonString);
        }

        private string getRootPath()
        {
            var basePath = AppContext.BaseDirectory;

            return Path.GetFullPath(Path.Combine(basePath, @"..\..\.."));
        }
    }
}

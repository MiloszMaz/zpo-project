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

                string outputPath = Path.Combine(this.getRootPath(), _configService.getOutputFilePath());

                File.WriteAllText(outputPath, jsonString);
            } catch(Exception exception) {
                throw new FileException("Error on save data: " + exception.Message);
            }
        }

        private string getRootPath()
        {
            var basePath = AppContext.BaseDirectory;

            return Path.GetFullPath(Path.Combine(basePath, @"..\..\.."));
        }
    }
}

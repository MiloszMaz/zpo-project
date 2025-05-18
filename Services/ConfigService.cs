using System.Text.Json;
using projekt.Dto;

namespace projekt.Services
{
    public class ConfigService
    {
        private readonly SettingsDto settingsDto;

        public ConfigService()
        {
            var json = File.ReadAllText("appsettings.json");
            settingsDto = JsonSerializer.Deserialize<SettingsDto>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? throw new Exception("Error on load settings");
        }

        public string getOutputFilePath()
        {
            return settingsDto.outputFilePath;
        }
    }
}

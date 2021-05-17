using Microsoft.Extensions.Configuration;
using Messari;

namespace MessariTest.Helpers
{
    public class TestHelper
    {
        public static IConfigurationRoot GetIConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddUserSecrets("8e97cc9c-4da5-4dd8-a3f2-6f37bd13a0ae")
                .AddEnvironmentVariables()
                .Build();
        }

        public static MessariClientConfiguration GetApplicationConfiguration(string outputPath)
        {
            var configuration = new MessariClientConfiguration();

            var iConfig = GetIConfigurationRoot(outputPath);

            iConfig
                .GetSection("MessariClientSettings")
                .Bind(configuration);

            return configuration;
        }
    }
}

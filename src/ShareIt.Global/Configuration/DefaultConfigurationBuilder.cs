using Microsoft.Extensions.Configuration;
using System.IO;

namespace ShareIt.Global.Configuration
{
    public class DefaultConfigurationBuilder : ConfigurationBuilder
    {
        public DefaultConfigurationBuilder()
        {
            this.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json")
                .AddJsonFile("appsettings.Production.json", true)
                .AddEnvironmentVariables();
        }
    }
}

using Microsoft.Extensions.Configuration;
using System;

namespace ShareIt.Global.Configuration
{
    public static class IConfigurationExtensions
    {
        public static string GetDefaultConnectionString(this IConfiguration @this)
        {
            var connectionString = @this.GetConnectionString("DefaultConnection") ?? @this.GetConnectionString("DefaultConnectionConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new SystemException("Default connection string not found.");
            }

            return connectionString;
        }
    }
}

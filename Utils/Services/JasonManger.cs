using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Utils.Models;

namespace Utils.Services
{
    public class JasonManger
    {
        static IConfigurationRoot? configuration;
        public static void SetJeson()
        {
            IConfigurationBuilder configbuilder  = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
            configuration = configbuilder.Build();
        }
        public static string GetConnectionString() => configuration.GetConnectionString("DefaultConnection");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        public static string GetSection(string sectionName) => configuration.GetSection(sectionName).Value;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}

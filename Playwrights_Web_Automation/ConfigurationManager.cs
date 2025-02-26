using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace Playwrights_Web_Automation
{
    public static class ConfigurationManager
    {
        private static readonly IConfiguration _configuration;

        static ConfigurationManager()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string basePath = Directory.GetParent(path: Directory.GetCurrentDirectory()).Parent.Parent.FullName;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
        }

        public static string BaseUrl => _configuration["BaseUrl"];

        public static string Username => _configuration["Username"];
        public static string Password => _configuration["Password"];
    }
}


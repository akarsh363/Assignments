using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex27ReadingConfig
    {
        public static IConfigurationRoot AppConfig { get; private set; }

        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) 
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            AppConfig = config;
            var appName = config["AppSettings:AppName"];
            var title = config["AppSettings:Title"];
            Console.WriteLine($"~~~~~~~~{appName.ToUpper()}~~~~~~~~~~~~~~~~");
            Console.WriteLine($"~~~~~~~~~~~~~{title.ToUpper()}");
            Console.ReadLine();

            var appSettings = new AppSettings();
            config.GetSection("AppSettings").Bind(appSettings);
            // Bind the configuration to a class.Use Microsoft.Extensions.Configuration.Binder package. This is the widely used approach to read the configuration settings in a strongly typed manner.
            Console.WriteLine(appSettings.Title);
        }
    }

    class AppSettings
    {
        public string AppName {  get; set; } = string .Empty;

        public string Title { get; set; } = string.Empty;
    }
}

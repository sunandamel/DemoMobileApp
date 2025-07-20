using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDemoMobileApp
{
    public static class AppSettingsLoader
    {
        public static IConfiguration Configuration { get; }

        static AppSettingsLoader()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory) // or use AppContext.BaseDirectory
                .AddJsonFile("appsettings.json", optional: false)
                .Build();
        }
    }
}

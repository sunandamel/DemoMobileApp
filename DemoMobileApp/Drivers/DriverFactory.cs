using DemoMobileApp.Drivers;
using Microsoft.Extensions.Configuration;
using NewDemoMobileApp;
using Newtonsoft.Json;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Runtime;



namespace DemoMobileApp.Drivers
{

    public class DriverFactory : IDisposable
    {
        public AndroidDriver Driver { get; private set; }


        public DriverFactory()
        {

            var platform = AppSettingsLoader.Configuration.GetValue<string>("platform");
            var settings = AppSettingsLoader.Configuration.GetSection(platform).Get<PlatformConfig>();
            var options = new AppiumOptions();
            options.PlatformName = platform;
            options.AutomationName = settings.AutomationName;
            options.DeviceName = settings.DeviceName;

            // Get the base directory where your test assembly is running
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Construct relative path from the base directory to your APK file
            string relativePath = settings.AppPath;

            // Combine and get full absolute path
            string appPath = Path.GetFullPath(Path.Combine(basePath, relativePath));

            // Assign to Appium options
            options.App = appPath;

            options.AddAdditionalAppiumOption("appWaitActivity", "*");
            Driver = new AndroidDriver(new Uri("http://127.0.0.1:4723"), options);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void Dispose()
        {
            Driver?.Quit();
            Driver?.Dispose();
        }
    }
}




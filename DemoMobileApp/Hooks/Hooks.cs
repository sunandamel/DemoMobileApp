using System;
using TechTalk.SpecFlow;
using DemoMobileApp.Drivers;


namespace DemoMobileApp.Hooks
{
    [Binding]
    public sealed class Hooks : IDisposable
    {
        private readonly DriverFactory driverFactory;

        public Hooks(DriverFactory driverFactory)
        {
            this.driverFactory = driverFactory;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Driver is initialized by DriverFactory constructor
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driverFactory.Dispose();
        }

        public void Dispose()
        {
            driverFactory.Dispose();
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using DemoMobileApp.Drivers;
using DemoMobileApp.Pages;

namespace DemoMobileApp.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly AndroidDriver driver;
        private readonly LoginPage loginPage;

        public LoginSteps(DriverFactory driverFactory)
        {
            driver = driverFactory.Driver;
            loginPage = new LoginPage(driver);
        }


        [Given(@"the app is launched")]
        public void GivenTheAppIsLaunched()
        {
            // Driver is already initialized and app launched by Hooks
        }

        [When(@"I tap on the ""(.*)""")]
        public void WhenITapOnThe(string username)
        {
            loginPage.TapUsername(username);
        }

        [When(@"I tap on the ""(.*)"" button")]
        public void WhenITapOnTheButton(string buttonName)
        {
            loginPage.TapLoginButton();
        }

        [Then(@"I should see the ""(.*)"" screen")]
        public void ThenIShouldSeeTheScreenOrError(string expectedText)
        {
            bool isDisplayed = loginPage.IsScreenOrErrorDisplayed(expectedText);
            Assert.IsTrue(isDisplayed, $"Expected screen or error with text '{expectedText}' was not found.");
        }



    }
}

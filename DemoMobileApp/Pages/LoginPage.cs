using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;

namespace DemoMobileApp.Pages
{
    public class LoginPage
    {
        private readonly AndroidDriver driver;

        // Static locators
        private readonly By loginButtonLocator = By.XPath("//android.view.ViewGroup[@content-desc='test-LOGIN']");

        public LoginPage(AndroidDriver driver)
        {
            this.driver = driver;
        }

        public void TapUsername(string username)
        {
            driver.FindElement(By.XPath($"//android.widget.TextView[@text='{username}']")).Click();
        }

        public void TapLoginButton()
        {
            driver.FindElement(loginButtonLocator).Click();
        }

        public bool IsScreenOrErrorDisplayed(string expectedText)
        {
            var elements = driver.FindElements(By.XPath($"//android.widget.TextView[contains(@text,'{expectedText}')]"));
            return elements.Count > 0;
        }

    }
}

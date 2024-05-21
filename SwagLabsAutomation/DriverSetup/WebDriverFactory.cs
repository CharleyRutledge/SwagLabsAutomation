using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SwagLabsAutomation.DriverSetup
{
    public class WebDriverFactory
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        public WebDriverFactory(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}

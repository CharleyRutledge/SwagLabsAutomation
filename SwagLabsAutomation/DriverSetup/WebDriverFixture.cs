using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsAutomation.DriverSetup
{
    public class WebDriverFixture: IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public WebDriverFixture()
        {
            // Initialize the WebDriver (e.g., ChromeDriver)
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.saucedemo.com"); // Navigate to the URL
        }

        public void Dispose()
        {
            // Cleanup the WebDriver instance
            Driver.Quit();
        }
    }
}

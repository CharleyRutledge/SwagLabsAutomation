using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SwagLabsAutomation.DriverSetup
{
    public static class CreateDriver
    {
        public static IWebDriver GetDriver(string browser)
        {
            switch (browser)
            {
                case "chrome":
                    return new ChromeDriver();
                case "firefox":
                    return new FirefoxDriver();
                case "edge":
                    return new EdgeDriver();
                default:
                    throw new Exception("Invalid browser");
            }
        }
    }
}

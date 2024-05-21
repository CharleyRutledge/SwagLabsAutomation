using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SwagLabsAutomation.Base
{
    public class BaseClass
    {
        protected IWebDriver Driver;
        protected WebDriverWait Wait;

        /// <summary>
        /// This is the constructor of the Base class
        /// </summary>
        /// <param name="driver"></param>
        public BaseClass(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}

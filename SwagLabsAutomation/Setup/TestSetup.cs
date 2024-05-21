using NUnit.Framework;
using OpenQA.Selenium;
using SwagLabsAutomation.DriverSetup;

namespace SwagLabsAutomation.Setup
{
    [TestFixture]
    public abstract class TestSetup
    {
        protected IWebDriver? driver;

        /// <summary>
        /// Runs once before all tests in the derived classes
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetUp() { }

        /// <summary>
        /// Selects the browser and navigates to the URL
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            driver = CreateDriver.GetDriver("chrome");
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        /// <summary>
        /// Tears down the driver after each test
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // This runs after each test
            if (driver != null)
            {
                driver.Quit();
            }
        }

        /// <summary>
        /// This runs once after all tests in the derived classes
        /// </summary>
        [OneTimeTearDown]
        public void OneTimeTearDown() { }
    }
}

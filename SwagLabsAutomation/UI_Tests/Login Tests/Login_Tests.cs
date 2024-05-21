using OpenQA.Selenium;
using SwagLabsAutomation.DriverSetup;
using SwagLabsAutomation.UI_Data;
using Xunit;

namespace SwagLabsAutomation.UI_Tests
{
    public class Login_Tests : IClassFixture<WebDriverFixture>
    {
        private readonly IWebDriver _driver;

        public Login_Tests(WebDriverFixture fixture)
        {
            _driver = fixture.Driver;
        }


        [Fact]
        public void LoginAsStandardUser()
        {
            new Login_User_Data(_driver)
                .Login_Standard_User();
        }

    }
}

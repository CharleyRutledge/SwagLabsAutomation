using OpenQA.Selenium;
using SwagLabsAutomation.Base;
using SwagLabsAutomation.UI_Tests;

namespace SwagLabsAutomation.UI_Data
{
    public class Login_User_Data : BaseCommonMethods
    {
        #region Driver Constructor
        public Login_User_Data(IWebDriver driver) : base(driver){}

        #endregion Driver Constructor

        #region user_details

        private string standard_user = "standard_user";
        private string locked_out_user = "locked_out_user";
        private string problem_user = "problem_user";
        private string performance_glitch_user = "performance_glitch_user";
        private string error_user = "error_user";
        private string visual_user = "visual_user";
        private string password = "secret_sauce";

        #endregion user_details

        #region Login_page_locators

        public By usernameField = By.Id("user-name");
        public By passwordField = By.Id("password");
        public By loginButton = By.Id("login-button");

        #endregion Login_page_locators

        /// <summary>
        /// Login as a standard user
        /// </summary>
        /// <returns></returns>
        public Login_User_Data Login_Standard_User()
        {
            Login(standard_user, password);

            return this;
        }

        /// <summary>
        /// Login function using the user and password as parameters
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        private void Login(string user, string password)
        {
            TypeText(usernameField, user);
            TypeText(passwordField, password);
            Click(loginButton);
        }
    }
}
using OpenQA.Selenium;

namespace SwagLabsAutomation.Base
{
    public class BaseCommonMethods : BaseClass
    {
        #region Driver Constructor
        public BaseCommonMethods(IWebDriver driver) : base(driver) { }

        #endregion Class Constructor

        /// <summary>
        /// Clicks the element after finding it by the locator
        /// </summary>
        /// <param name="locator"></param>
        public void Click(By locator)
        {
            Driver.FindElement(locator).Click();

        }

        /// <summary>
        /// Types the text in the element
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="text"></param>
        public void TypeText(By locator, string text)
        {
            Driver.FindElement(locator).SendKeys(text);

        }

        /// <summary>
        /// Clears the text in the element
        /// </summary>
        /// <param name="locator"></param>
        public void Clear(By locator)
        {
            Driver.FindElement(locator).Clear();
        }
    }
}

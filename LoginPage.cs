

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace MobileTestCases

{
    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.input-field > input")]
        public IWebElement MobileNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.buttons-field > div > span")]
        public IWebElement OKButton { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.user-name > input")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.user-pass > input")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div:nth-child(4) > button > span")]
        public IWebElement LoginButton { get; set; }
    }
}

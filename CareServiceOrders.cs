

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace MobileTestCases
{
    class CareServiceOrders
    {
        public CareServiceOrders()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-view-login-subscriber > div > div:nth-child(1)")]
        public IWebElement ACare { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.my-order-deliveries > div > span.text")]
        public IWebElement MyWorkOrderTask { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div")]
        public IWebElement WholePage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.bottom-panel > div.button-back.box > span > span")]
        public IWebElement BackButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.bottom-panel.type-common > div.button.menu > span > span")]
        public IWebElement LogoutButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.logout > div > span.text")]
        public IWebElement Logout { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-view-login-subscriber > div > div:nth-child(2)")]
        public IWebElement AService { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.my-order-deliveries > div > span.text")]
        public IWebElement MyWorkOrderTask1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div")]
        public IWebElement WholePage1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.bottom-panel > div.button-back.box > span > span")]
        public IWebElement BackButton1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.bottom-panel.type-common > div.button.menu > span > span")]
        public IWebElement LogoutButton1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.logout > div > span.text")]
        public IWebElement Logout1 { get; set; }



    }
}

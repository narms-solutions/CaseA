

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace MobileTestCases
{
    class ServiceMyOrderTasks
    {
        public ServiceMyOrderTasks()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.my-order-deliveries > div > span.text")]
        public IWebElement MyWorkOrderTask { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div")]
        public IWebElement WholePage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.bottom-panel > div.button-back.box")]
        public IWebElement BackButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.change-delivery-plan > div > span.text")]
        public IWebElement ChangeMYOrderTasks { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#srvi_1_1 > div.button.arrow")]
        public IWebElement MYOrderArrow { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.content")]
        public IWebElement OrdersContainer { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.bottom-panel > div.button-back.box")]
        public IWebElement BackToOrders { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.bottom-panel > div.button-ignore.box")]
        public IWebElement BackToMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.bottom-panel.type-common > div.button.menu > span")]
        public IWebElement LogoutButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.logout > div > span.text")]
        public IWebElement Logout { get; set; }
    }
}

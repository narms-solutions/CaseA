

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace MobileTestCases
{
    class CaseA5WorkOrderTasks
    {
        public CaseA5WorkOrderTasks()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.my-order-deliveries > div > span.text")]
        public IWebElement MyWorkOrderTask { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container")]
        public IWebElement WholePage { get; set; }

       
        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(1) > div")]
        public IWebElement Order1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(2) > div > span")]
        public IWebElement Order2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group > span")]
        public IWebElement PartlyPlanned { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list2 > div:nth-child(1) > div > span")]
        public IWebElement Order3 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list2 > div:nth-child(2) > div > span")]
        public IWebElement Order4 { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-back.box > span > span")]
        public IWebElement BackButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.change-delivery-plan > div > span.text")]
        public IWebElement ChangeMYOrderTasks { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#srvi_3_6 > div.button.arrow")]
        public IWebElement MyOrderArrow { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.content")]
        public IWebElement OrdersContainer { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.bottom-panel > div.button-back.box")]
        public IWebElement BackToOrders { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.bottom-panel > div.button-ignore.box")]
        public IWebElement BackToMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.bottom-panel.type-common > div.button.menu > span > span")]
        public IWebElement LogoutButton { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.logout > div > span.text")]
        public IWebElement Logout { get; set; }

       


    }
}

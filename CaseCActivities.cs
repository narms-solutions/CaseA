

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace MobileTestCases
{
    class CaseCActivities
    {
        public CaseCActivities()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //////////////////////////////////CaseC - 5 UnplannedTasks////////////////////////////
        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.start-without-order")]
        public IWebElement CaseCUnplanned { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-view-confirm-popup.three-button > div.button.start_end")]
        public IWebElement StartAndEnd { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.organization-item")]
        public IWebElement TopSubscriber { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div:nth-child(3)")]
        public IWebElement KeyCustomer { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div:nth-child(2)")]
        public IWebElement PreSchoolCustomer { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.activity-item.parent-activity")]
        public IWebElement Activities { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.bottom-panel > div.button-back.box")]
        public IWebElement BackButton { get; set; }

        ////////////////////////////////////CaseC - 6 Unplanned Contract/////////////////////////////

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.ordered-unplanned > div > span.indicator")]
        public IWebElement CaseCUnplanContractIndicator { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.one-line.item-parent.customer")]
        public IWebElement CarinaSubscriber { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.one-line.item-list.customer.expanded > div:nth-child(2)")]
        public IWebElement Care { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-view-confirm-popup > div")]
        public IWebElement EndButton { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.bottom-panel > div.button-send > span")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.one-line.item-list.customer.expanded > div:nth-child(3)")]
        public IWebElement Service { get; set; }

        ///////////////////////////////CaseCMyWorkOrderTasks/////////////////////////////////////

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.my-order-deliveries")]
        public IWebElement CMyWorkOrderTasks { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(1)")]
        public IWebElement FirstDelivery { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(2)")]
        public IWebElement SecondDelivery { get; set; }

        [FindsBy(How=How.CssSelector,Using="#check_start_end")]
        public IWebElement StartandEndCheckBox { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-start")]
        public IWebElement StartDeliveryButton { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.bottom-panel > div.button-back.box > span")]
        public IWebElement BackToDeliveries { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.bottom-panel > div.button-back.box")]
        public IWebElement BackToList { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-back.box > span")]
        public IWebElement BackMenu { get; set; }

    }
}

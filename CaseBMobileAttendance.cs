

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace MobileTestCases
{
    class CaseBMobileAttendance
    {
        public CaseBMobileAttendance()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.start-attendance")]
        public IWebElement CaseBAttend { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.main-content > div.left-panel > div.group-list.section.absent.show")]
       public IWebElement AttendanceContainer { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.bottom-panel > div > span")]
       public IWebElement BackButton { get; set; }


        //////////////////////////////WorkShift//////////////////////

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.start-work-shift")]
        public IWebElement CaseBWorkShift { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.main-content")]
        public IWebElement WorkshiftContainer { get; set; }//#avista-global-container > div > div.container > div.main-content > div.left-panel > div.group-list.section.absent.show > div.group-list.section.org.noplan.show


        /////////////////////////////MyWorkOrders////////////////////////

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.my-order-deliveries")]
        public IWebElement CaseBWorkOrderDeliveries { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.order-list-container")]
        public IWebElement OrderDeliveryContainer { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-next > span")]
        public IWebElement NextdayButton { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-back.box")]
        public IWebElement Back { get; set; }

        ////////////////////////////ChangeMyWorkOrder////////////////////////

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.change-delivery-plan")]
        public IWebElement ChangeTodaysWorkOrder { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-ignore.box")]
        public IWebElement ChangeBackButton { get; set; }

        /////////////////////////////CaseB-5MobileAttendance/////////////////
        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.top-panel > table > tbody > tr > td:nth-child(3)")]
        public IWebElement AttendanceSettings { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.main-content > div > div > div:nth-child(2) > input")]
        public IWebElement SendPassword { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.main-content > div > div > div:nth-child(3) > input")]
        public IWebElement KeyOkButton { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.top-panel > table > tbody > tr > td:nth-child(1)")]
        public IWebElement Presence { get; set; }


        ///////////////////////////////////CaseB-6 MobileWorkShiftService////////////////////
        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-view-login-subscriber > div > div:nth-child(1)")]
        public IWebElement caseBOrgUnit { get; set; }


    }
}

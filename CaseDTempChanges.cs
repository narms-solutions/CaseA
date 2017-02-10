

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace MobileTestCases
{
    class CaseDTempChanges
    {
        public CaseDTempChanges()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.my-order-deliveries")]
        public IWebElement CaseDMWOT { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-next > span")]
        public IWebElement Nextday { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-back.box")]
        public IWebElement BackButton { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-main-content.main-menu > div > div")]
        public IWebElement CaseEMWOT { get; set; }
    }
}



using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace MobileTestCases
{
    class CaseGTempResourceChange
    {
        public CaseGTempResourceChange()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.change-delivery-plan > div")]
        public IWebElement CaseGChangeTodaysPlan { get; set; }

        [FindsBy(How=How.CssSelector,Using="#srvi_40_148 > input")]
        public IWebElement GretaCheckBox { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-save.box > span")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-ignore.box")]
        public IWebElement BackButton { get; set; }
    }
}

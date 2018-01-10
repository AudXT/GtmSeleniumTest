using GtmSeleniumTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GtmSeleniumFramework.Pages
{
    public class CheerPage : GtmSportswearBasePage
    {

        public bool IsAtCheerleading()
        {
            var cheerPage = new CheerPage();
            PageFactory.InitElements(Browser.Driver, cheerPage);
            return cheerPage.Header == "CHEER";
        }
    }
}

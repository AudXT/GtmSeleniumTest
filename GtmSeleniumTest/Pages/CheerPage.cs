using GtmSeleniumTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GtmSeleniumFramework.Pages
{
    public class CheerPage
    {
        [FindsBy(How = How.CssSelector, Using = "#ctl00_ContentPlaceHolder1_divCategoryContainer > div:nth-child(1) > article > h1")]
        private IWebElement header;
        public string Header
        {
            get { return header.Text; }
        }

        public bool IsAtCheerleading()
        {
            var cheerPage = new CheerPage();
            PageFactory.InitElements(Browser.Driver, cheerPage);
            return cheerPage.Header == "CHEER";
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtmSeleniumTest.Pages
{
    public class GtmSportswearBasePage
    {
        

        protected string Url;
        protected string PageTitle;

        public GtmToolBar ToolBar = new GtmToolBar();

        [FindsBy(How = How.ClassName, Using = "header__search")]
        private IWebElement searchBox;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_ContentPlaceHolder1_divCategoryContainer > div:nth-child(1) > article > h1")]
        private IWebElement header;

        [FindsBy(How = How.Id, Using = "ctl00_lblAccountName")]
        private IWebElement loginBtn;

        public string Header
        {
            get { return header.Text; }
        }

        /// <summary>
        /// Checks the see if the current page title is the same as the page objects title
        /// </summary>
        /// <returns>If the page title matches page object title</returns>
        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        /// <summary>
        /// Type something into the search box at the top of the page and search
        /// </summary>
        /// <param name="searchTerm">What you would like to search for</param>
        public void Search(string searchTerm)
        {
            searchBox.SendKeys(searchTerm);
            searchBox.SendKeys(Keys.Return);
        }

        /// <summary>
        /// Go to the url of the page item
        /// </summary>
        public void Goto()
        {
            Browser.Goto(Url);
        }

        public void GotoLogin() => loginBtn.Click();
    }

    public class GtmToolBar
    {
        [FindsBy(How = How.LinkText, Using = "Cheerleading")]
        private IWebElement cheerleading;

        public void SelectCheerleading(string choice)
        {
            cheerleading.Click();
            var link = Browser.Driver.FindElement(By.LinkText(choice));
            link.Click();
        }
    }
}

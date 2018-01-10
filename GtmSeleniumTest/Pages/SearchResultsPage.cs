using GtmSeleniumTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace GtmSeleniumFramework.Pages
{
    public class SearchResultsPage : GtmSportswearBasePage
    {
        public SearchResultsPage()
        {
            string Url = "https://gtmsportswear.com/searchresults.aspx?w=";
            string PageTitle = "Search Results - GTM Sportswear";

            var wait = new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.ClassName("productCard")));
        }


        [FindsBy(How = How.ClassName, Using = "productCard")]
        private IList<IWebElement> results;

        public void GoTo(string searchTerm)
        {
            Browser.Goto($"{Url}{searchTerm}");
        }

        public void SelectResult(int resultNum)
        {
            results[resultNum].Click();
        }
    }
}

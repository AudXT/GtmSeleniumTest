using GtmSeleniumTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GtmSeleniumFramework.Pages
{
    public class HomePage
    {
        static string Url = "http://gtmsportswear.com";

        static string PageTitle = "Warm Ups, Uniforms, Custom Jerseys, Tees, Embroidery | GTM Sportswear";

        [FindsBy(How = How.LinkText, Using = "Cheerleading")]
        private IWebElement cheerleading;

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectCheerleading(string choice)
        {
            cheerleading.Click();
            var link = Browser.Driver.FindElement(By.LinkText(choice));
            link.Click();
        }

    }
}

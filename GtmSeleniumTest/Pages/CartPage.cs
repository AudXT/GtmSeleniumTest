using GtmSeleniumTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace GtmSeleniumFramework.Pages
{
    public class CartPage : GtmSportswearBasePage
    {
        [FindsBy(How = How.ClassName, Using = "show-for-medium-up")]
        private IWebElement checkoutButton;

        public CartPage()
        {
            var wait = new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(20));
            wait.Until(d => d.FindElement(By.ClassName("cart__checkoutButton")));
        }

        /// <summary>
        /// Click the checkout button
        /// </summary>
        public void Checkout()
        {
            checkoutButton.Click();
        }
    }
}

using GtmSeleniumTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace GtmSeleniumFramework.Pages
{
    public class ProductPage : GtmSportswearBasePage
    {
        public ProductPage()
        {
            var wait = new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.ClassName("team-order-matrix__style__sizes")));
        }

        #region WebElements
        [FindsBy(How = How.ClassName, Using = "team-order-matrix__style__sizes")]
        private IWebElement teamOrderMatrix;

        [FindsBy(How = How.ClassName, Using = "product-information__addToCart")]
        private IWebElement addToCartButton;

        [FindsBy(How = How.ClassName, Using = "product-information__addDesign")]
        private IWebElement addDesignButton;
        #endregion

        /// <summary>
        /// increase the number of product to add to your cart
        /// </summary>
        /// <param name="productToIncrease">Element name of product to increase, format "Men's-S"</param>
        /// <param name="amount">The amount you would like to add</param>
        public void AddProduct(string productToIncrease, int amount)
        {
            IWebElement item = teamOrderMatrix.FindElement(By.Name(productToIncrease));
            item.SendKeys(amount.ToString());
        }

        /// <summary>
        /// Click the add to cart button
        /// </summary>
        public void AddToCart()
        {
            addToCartButton.Click();
        }

        /// <summary>
        /// Click the add design button
        /// </summary>
        public void AddDesign()
        {
            addDesignButton.Click();
        }
    }
}

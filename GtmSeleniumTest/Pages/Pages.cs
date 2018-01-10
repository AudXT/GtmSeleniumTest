using GtmSeleniumTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtmSeleniumFramework.Pages
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }

        public static CheerPage CheerPage
        {
            get
            {
                var cheerPage = new CheerPage();
                PageFactory.InitElements(Browser.Driver, cheerPage);
                return cheerPage;
            }
        }

        public static SearchResultsPage SearchResultPage
        {
            get
            {
                var searchPage = new SearchResultsPage();
                PageFactory.InitElements(Browser.Driver, searchPage);
                return searchPage;
            }
        }

        public static ProductPage ProductPage
        {
            get
            {
                var productPage = new ProductPage();
                PageFactory.InitElements(Browser.Driver, productPage);
                return productPage;
            }
        }

        public static CartPage CartPage
        {
            get
            {
                var cartPage = new CartPage();
                PageFactory.InitElements(Browser.Driver, cartPage);
                return cartPage;
            }
        }

        public static CheckoutPage CheckoutPage
        {
            get
            {
                var checkoutPage = new CheckoutPage();
                PageFactory.InitElements(Browser.Driver, checkoutPage);
                return checkoutPage;
            }
        }
    }

}

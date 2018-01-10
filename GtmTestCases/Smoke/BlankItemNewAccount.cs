using System;
using System.Threading;
using GtmSeleniumFramework.Pages;
using GtmSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GtmTestCases
{
    [TestClass]
    public class BlankItemNewAccount : TestBase
    {
        //[TestMethod]
        //public void ST_003()
        //{
        //    RunTestWithExceptionHandling(DoTestProcedure);
        //}
        [TestMethod]
        public void ST_003()
        {
            //Go to the home page and search for something (Tagless shirt)
            Pages.HomePage.Goto();
            Pages.HomePage.Search("Tagless");

            //Select something fromt he list
            Pages.SearchResultPage.SelectResult(1);

            //Add something to your cart
            Pages.ProductPage.AddProduct("Men's-S", 1);
            Pages.ProductPage.AddToCart();

            //Go to checkout
            Pages.CartPage.Checkout();

            //Verify > No errors are present at login screen
            Assert.IsFalse(Pages.CheckoutPage.NewCustomerCheckError("First Name"), "First Name error is present");
            Assert.IsFalse(Pages.CheckoutPage.NewCustomerCheckError("Last Name"), "Last name error is present");
            Assert.IsFalse(Pages.CheckoutPage.NewCustomerCheckError("E-Mail Address"), "Email error is present");
            Assert.IsFalse(Pages.CheckoutPage.NewCustomerCheckError("Password"), "Password error is present");
            Assert.IsFalse(Pages.CheckoutPage.NewCustomerCheckError("Confirm Password"), "Confirm Password error is present");

            //Attempt to register for account without putting any information
            Pages.CheckoutPage.Register();

            //Verify errors show up
            Assert.IsTrue(Pages.CheckoutPage.NewCustomerCheckError("First Name"), "First Name error is not present");
            Assert.IsTrue(Pages.CheckoutPage.NewCustomerCheckError("Last Name"), "Last name error is not present");
            Assert.IsTrue(Pages.CheckoutPage.NewCustomerCheckError("E-Mail Address"), "Email error is not present");
            Assert.IsTrue(Pages.CheckoutPage.NewCustomerCheckError("Password"), "Password error is not present");
            Assert.IsTrue(Pages.CheckoutPage.NewCustomerCheckError("Confirm Password"), "Confirm Password error is not present");

            //Fill out information with dummy info
            Pages.CheckoutPage.FillFirstName("Test");
            Pages.CheckoutPage.FillLastName("Test");
            Pages.CheckoutPage.FillEmail("Test@test.com");
            Pages.CheckoutPage.FillPassword("Testtest1");
            Pages.CheckoutPage.FillPasswordConfirm("Testtest1");

        }
    }
}

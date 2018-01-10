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
        //public void ST_01()
        //{
        //    RunTestWithExceptionHandling(DoTestProcedure);
        //}
        [TestMethod]
        public void ST_01()
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
            Assert.IsFalse(Pages.LoginPage.NewCustomerCheckError("First Name"), "First Name error is present");
            Assert.IsFalse(Pages.LoginPage.NewCustomerCheckError("Last Name"), "Last name error is present");
            Assert.IsFalse(Pages.LoginPage.NewCustomerCheckError("E-Mail Address"), "Email error is present");
            Assert.IsFalse(Pages.LoginPage.NewCustomerCheckError("Password"), "Password error is present");
            Assert.IsFalse(Pages.LoginPage.NewCustomerCheckError("Confirm Password"), "Confirm Password error is present");

            //Attempt to register for account without putting any information
            Pages.LoginPage.Register();

            //Verify errors show up
            Assert.IsTrue(Pages.LoginPage.NewCustomerCheckError("First Name"), "First Name error is not present");
            Assert.IsTrue(Pages.LoginPage.NewCustomerCheckError("Last Name"), "Last name error is not present");
            Assert.IsTrue(Pages.LoginPage.NewCustomerCheckError("E-Mail Address"), "Email error is not present");
            Assert.IsTrue(Pages.LoginPage.NewCustomerCheckError("Password"), "Password error is not present");
            Assert.IsTrue(Pages.LoginPage.NewCustomerCheckError("Confirm Password"), "Confirm Password error is not present");

            //Fill out information with dummy info
            Pages.LoginPage.FillFirstName("Test");
            Pages.LoginPage.FillLastName("Test");
            Pages.LoginPage.FillEmailNew($"Test{DateTime.Now.ToString()}@test.com");
            Pages.LoginPage.FillPasswordNew("Testtest1");
            Pages.LoginPage.FillPasswordConfirm("Testtest1");

        }
    }
}

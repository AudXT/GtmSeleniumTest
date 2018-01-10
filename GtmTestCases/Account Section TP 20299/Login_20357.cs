using System;
using GtmSeleniumFramework.Pages;
using GtmSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GtmTestCases
{
    [TestClass]
    public class Login_20357 : TestBase
    {
        [TestMethod]
        public void TC20357()
        {
            //Go to home page
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt(), "Not at home page");

            //Go to Login page
            Pages.HomePage.GotoLogin();
            Assert.IsTrue(Pages.LoginPage.IsAt(), "Not at the login page");

            //Try logging in with invalid email
            Pages.LoginPage.FillEmail("badEmail");
            Pages.LoginPage.Login();

            //Check for error
            Assert.IsTrue(Pages.LoginPage.NewCustomerCheckError("E-Mail Address"));

            //Enter valid email and attempt to login
            Pages.LoginPage.FillEmail("dennis.lukowski@igtm.com");
            Pages.LoginPage.Login();

            //Check for error
            Assert.IsFalse(Pages.LoginPage.NewCustomerCheckError("E-Mail Address"));

            //Enter valid password
            Pages.LoginPage.FillPassword("Vikings1");
            Pages.LoginPage.Login();

            //Verify > is at account home
        }
    }
}

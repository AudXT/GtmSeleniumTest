using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using GtmSeleniumTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GtmSeleniumTest
{
    [TestClass]
    public class TestBase
    {
        //public static String useCase = "Chrome";
        //public static Browser browser;
        //protected static string url = "https://gtmsportswear.com";

        //[AssemblyInitialize]
        //public static void PreSetup(TestContext testContext)
        //{
        //    switch (useCase)
        //    {
        //        case "Chrome":
        //            browser = new ChromeBrowser(url);
        //            break;
        //        default:
        //            throw new NotImplementedException("Use case not yet supported");
        //    }
        //}

        public List<TestAsserts> Asserts;
        public StringBuilder FailStrings;

        [TestInitialize]
        public void setupTest()
        {
            Asserts = new List<TestAsserts>();
            FailStrings = new StringBuilder();
        }

        public void RunTestWithExceptionHandling(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browser.Close();
        }
    }
}

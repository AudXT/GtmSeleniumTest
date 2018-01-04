using System;
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
        //[TestInitialize]
        //public void setupTest()
        //{
        //    browser.StartUp();
        //}

        public static void RunTestWithExceptionHandling(Action action)
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

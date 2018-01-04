using System;
using GtmSeleniumFramework.Pages;
using GtmSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GtmTestCases
{
    [TestClass]
    public class ChearleadingPageTest : TestBase
    {
        [TestMethod]
        public void TC_002()
        {
            RunTestWithExceptionHandling(DoTestProcedure);
        }

        private void DoTestProcedure()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectCheerleading("ALL CHEERLEADING");
            Assert.IsTrue(Pages.CheerPage.IsAtCheerleading(), "Not at cheerleading page");
        }
    }
}

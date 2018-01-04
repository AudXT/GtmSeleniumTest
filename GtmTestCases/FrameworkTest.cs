using System;
using GtmSeleniumFramework.Pages;
using GtmSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GtmTestCases
{
    [TestClass]
    public class FrameworkTest : TestBase
    {
        [TestMethod]
        public void TC_001()
        {
            RunTestWithExceptionHandling(DoTestProcedure);
        }

        private void DoTestProcedure()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt(), "Not at home page");
        }
    }
}

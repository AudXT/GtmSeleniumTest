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
    }

}

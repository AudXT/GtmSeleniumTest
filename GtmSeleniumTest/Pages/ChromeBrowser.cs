using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GtmSeleniumTest.Pages
{
    public class ChromeBrowser : Browser
    {
        public ChromeBrowser(string url)
        {
            driver = new ChromeDriver();
        }
    }
}

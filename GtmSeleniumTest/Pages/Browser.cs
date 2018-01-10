using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace GtmSeleniumTest.Pages
{
    public abstract class Browser
    {
        //public static IWebDriver driver = new ChromeDriver();
        public static IWebDriver driver = new RemoteWebDriver(
            new Uri("http://localhost:4444/wd/hub"), new ChromeOptions().ToCapabilities());
            //new Uri("http://localhost:4444/wd/hub"), new DesiredCapabilities("Chrome", "", new Platform(PlatformType.Windows)));

        public static string Title
        {
            get { return driver.Title; } 
        }

        public static IWebDriver Driver
        {
            get { return driver; }
        }

        //public static void StartUp()
        //{
        //    new WebDriverWait(driver, ).Until(
        //        d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        //}

        public static void Goto(string url)
        {
            driver.Url = url;
        }

        public static void Close()
        {
            driver.Close();
        }
    }
}

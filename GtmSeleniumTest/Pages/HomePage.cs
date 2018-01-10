using GtmSeleniumTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GtmSeleniumFramework.Pages
{
    public class HomePage : GtmSportswearBasePage
    {
        public HomePage()
        {
            Url = "http://gtmsportswear.com";

            PageTitle = "Warm Ups, Uniforms, Custom Jerseys, Tees, Embroidery | GTM Sportswear";
        }
    }
}

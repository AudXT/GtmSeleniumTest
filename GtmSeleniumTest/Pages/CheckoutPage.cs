using GtmSeleniumTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace GtmSeleniumFramework.Pages
{
    public class CheckoutPage : GtmSportswearBasePage
    {
        public CheckoutPage()
        {
            var wait = new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(15));
            wait.Until(d => d.FindElement(By.Id("loginForm")));
        }

        #region WebElements
        [FindsBy(How = How.Id, Using = "registerForm")]
        private IWebElement registerForm;

        [FindsBy(How = How.Id, Using = "loginForm")]
        private IWebElement loginForm;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_btnRegister")]
        private IWebElement registerBtn;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_registerFirstName")]
        private IWebElement firstNameInput;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_registerLastName")]
        private IWebElement lastNameInput;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_registerEmail")]
        private IWebElement emailInput;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_registerPassword")]
        private IWebElement passwordInput;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_registerPasswordConfirm")]
        private IWebElement confirmPasswordInput;
        #endregion

        /// <summary>
        /// Fills out the First name form
        /// </summary>
        /// <param name="name">First name to use</param>
        public void FillFirstName(string name) => firstNameInput.SendKeys(name);

        /// <summary>
        /// Fills out the last name form
        /// </summary>
        /// <param name="name">last name to use</param>
        public void FillLastName(string name) => lastNameInput.SendKeys(name);

        /// <summary>
        /// Fills out the email form
        /// </summary>
        /// <param name="email">email to use</param>
        public void FillEmail(string email) => emailInput.SendKeys(email);

        /// <summary>
        /// Fills out the password
        /// </summary>
        /// <param name="pass">password to use</param>
        public void FillPassword(string pass) => passwordInput.SendKeys(pass);

        /// <summary>
        /// Fills out the confirm password
        /// </summary>
        /// <param name="cPass">confirm password to use</param>
        public void FillPasswordConfirm(string cPass) => confirmPasswordInput.SendKeys(cPass);

        /// <summary>
        /// Check if an error is present on the new customer form
        /// </summary>
        /// <param name="toCheckName">The name of the input to check</param>
        /// <returns>Was error present at specified form input</returns>
        public bool NewCustomerCheckError(string toCheckName)
        {
            IWebElement element = null;
            var formElements = registerForm.FindElements(By.ClassName("error"));
            foreach(var formElement in formElements)
            {
                if (formElement.Text == toCheckName)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Press the register button
        /// </summary>
        public void Register()
        {
            registerBtn.Click();
        }
    }
}

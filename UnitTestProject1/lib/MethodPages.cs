using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProject1.lib;

namespace UnitTestProject1.pages
{
    class MethodPages
    {
        private MethodLib _tests;

        public MethodPages(MethodLib methods)
        {
            _tests = methods;
        }

        public string EmailAdd = "abc12@gmail.com";
        public string Password = "1234abc";

        //loginLink
        public By LoginLink = By.ClassName("Login");
        //email
        public By EmailBox = By.Name("email");
        //password
        public By PwBox = By.Name("passwd");
        //loginBtn
        public By SubmitBtn = By.Name("SubmitLogin");
        //logoutBtn
        //public By LogoutBtn = By.Name("");

        public void Login()
        {
            IWebDriver browser = _tests.browser;
            browser.FindElement(LoginLink).Click();
            browser.FindElement(EmailBox).SendKeys(EmailAdd);
            browser.FindElement(PwBox).SendKeys(Password);
            browser.FindElement(SubmitBtn).Click();
            //browser.FindElement(LogoutBtn).Click();
        }

        public void PinaiklingLogin()
        {
            ClickSignInLink();
            InputEmail();
            InputPassword();
            LogOut();
        }

        public void ClickSignInLink()
        {
            IWebDriver browser = _tests.browser;
            browser.FindElement(LoginLink).Click();
        }

        public void InputEmail()
        {
            IWebDriver browser = _tests.browser;
            browser.FindElement(EmailBox).SendKeys(EmailAdd);
        }

        public void InputPassword()
        {
            IWebDriver browser = _tests.browser;
            browser.FindElement(PwBox).SendKeys(Password);
        }

        public void LogOut()
        {
            IWebDriver browser = _tests.browser;
            browser.FindElement(LoginLink).Click();
        }

    }
}

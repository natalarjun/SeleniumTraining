
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProject1.lib;

namespace SeleniumJuly202019.Pages
{
    public class DashboardREM
    {
        private MethodLib _test;

        public DashboardREM(MethodLib methods)
        {
            _test = methods;
        }

        public By LogoutBtn = By.ClassName("logout");

        public void ClickLogoutBtn()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(LogoutBtn).Click();
        }
    }
}

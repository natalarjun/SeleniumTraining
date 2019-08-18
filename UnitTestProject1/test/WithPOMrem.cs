using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProject1.pages;
using UnitTestProject1.lib;
using SeleniumJuly202019.Pages;

namespace UnitTestProject1.test
{
    [TestClass]
    public class WithPOMrem
    {
        MethodLib _test;
        DashboardREM _dash;
        HomePageREM _home;
        CreateAccount _reg;
   

        [TestInitialize]
        public void SetUp()
        {
            _test = new MethodLib();
            _dash = new DashboardREM(_test);
            _home = new HomePageREM(_test);
            _reg = new CreateAccount(_test);
        }

        [TestMethod]
        public void LoginLogout()
        {
            _test.InitializeBrowser();
            _home.PinaiksingLogin();
            _dash.ClickLogoutBtn();
        }
        [TestMethod]
        public void BulkLogin()
        {
            _test.InitializeBrowser();
            _home.FillData();
        }

        [TestMethod]
        public void RegisterEmail()
        {
            _test.InitializeBrowser();
            _reg.Registered();
        }

        [TestCleanup]
        public void Teardown()
        {
            IWebDriver browser = _test.browser;
            browser.Quit();
        }
    }
}

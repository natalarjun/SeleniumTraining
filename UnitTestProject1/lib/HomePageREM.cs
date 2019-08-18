using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumJuly202019.Pages;

namespace UnitTestProject1.lib
{
    public class HomePageREM
    {
        private MethodLib _test;
        DashboardREM _dash;

        public HomePageREM(MethodLib methods)
        {
            _test = methods;
            _dash = new DashboardREM(_test);
        }

        public string EmailAdd;
        public string Password;

        //loginlink
        public By LogInLink = By.ClassName("login");
        //email
        public By EmailBox = By.Name("email");
        //password
        public By PwBox = By.Name("passwd");
        //loginbtn
        public By SubmitBtn = By.Id("SubmitLogin");

        public void Login()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(LogInLink).Click();
            browser.FindElement(EmailBox).SendKeys(EmailAdd);
            browser.FindElement(PwBox).SendKeys(Password);
            browser.FindElement(SubmitBtn).Click();

        }

        internal void Registered()
        {
            throw new NotImplementedException();
        }

        public void PinaiksingLogin()
        {
            ClickSignInlink();
            InputEmail();
            InputPw();
            ClickSubmitBtn();
        }


        public void ClickSignInlink()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(LogInLink).Click();
        }

        public void InputEmail(String EmailAdd = "selenium@07202019.com")
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(EmailBox).SendKeys(EmailAdd);
        }

        public void InputPw(String Password = "123123A")
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(PwBox).SendKeys(Password);
        }

        public void ClickSubmitBtn()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(SubmitBtn).Click();
        }

        public void FillData()
        {
            string filepath = @"C:\\Users\\Trainee\\Documents\\trytry.csv";
            List<string> data = new List<string>();
            data = Servers.general.loadCsvFile(filepath);
            for (int i = 0; 1 < data.Count; i++)
            {
                var values = data[i].Split(';');
                ClickSignInlink();
                Thread.Sleep(3000);
                InputEmail(values[0]);
                InputPw(values[0]);
                ClickSubmitBtn();
                Thread.Sleep(3000);
                _dash.ClickLogoutBtn();
            }
        }
    }
}  


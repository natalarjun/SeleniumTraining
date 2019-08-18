using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumJuly202019.Pages;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1.lib
{
    public class CreateAccount
    {
        private MethodLib _test;
        DashboardREM _dash;

        public CreateAccount(MethodLib methods)
        {
            _test = methods;
            _dash = new DashboardREM(_test);
        }

        public string EmailAdd, email;
        public string Password;
        //public string Gender;
        public string FirstName;
        public string LastName;
        public string PassWord;
        public string Company, Address, City, ZipCode, state;
        public string MNum, Reference;

        //login
        public By EmailBox = By.Name("email");
        public By PwBox = By.Name("passwd");
        public By SubmitBtn = By.Id("SubmitLogin");
        //register
        public By LogInLink = By.ClassName("login");
        public By EmailCreateBox = By.Name("email_create");
        public By CreateAccnt = By.Name("SubmitCreate");
        public By SelectGender = By.CssSelector("#id_gender1");
        public By FName = By.Name("customer_firstname");
        public By LName = By.Name("customer_lastname");
        public By Pass = By.Name("passwd");
        public By Addrss = By.Name("address1");
        public By Cty = By.Name("city");
        public By PostCde = By.Name("postcode");
        public By Mobile = By.Name("phone_mobile");
        public By Refernce = By.Name("alias");
        public By RegisterBtn = By.Name("submitAccount");
        public By States = By.Name("id_state");

        //public void PinaiksingLogin()
        //{
        //  ClickSignInlink();
        //InputEmail();
        //InputPw();
        //ClickSubmitBtn();
        //}

        public void Registered()
        {
            ClickSignInlink();
            INputEmail();
           // InputTitle();
            InputFirstName();
            InputLastname();
            InputPassW();
            InputAddress();
            InputCity();
            selectState();
            InputZipcode();
            InputMobile();
            InputReference();
            ClickRegisterBtn();
        }


        public void ClickSignInlink()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(LogInLink).Click();
            Thread.Sleep(3000);
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

        public void selectState()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(LogInLink).Click();

            IWebElement state = browser.FindElement(States);

            SelectElement oSelect = new SelectElement(state);
            oSelect.SelectByIndex(2);
        }


        public void INputEmail(String email = "abc321@gmail.com")
        {
            Thread.Sleep(2000);
            IWebDriver browser = _test.browser;
            browser.FindElement(EmailCreateBox).SendKeys(email);
            Thread.Sleep(2000);
            browser.FindElement(CreateAccnt).Click();
            Thread.Sleep(2000);
        }

        public void InputTitle()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(SelectGender).Click();
        }

        public void InputFirstName(String FirstName = "Cristina")
        {
            Thread.Sleep(2000);
            IWebDriver browser = _test.browser;
            browser.FindElement(FName).SendKeys(FirstName);
        }
        public void InputLastname(String LastName = "Alba")
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(LName).SendKeys(LastName);
        }
        public void InputPassW(String PassWord = "cba321")
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(Pass).SendKeys(PassWord);
        }

        public void InputAddress(String Address = "Barangay")
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(Addrss).SendKeys(Address);
        }
        public void InputCity(String City = "Navotas City")
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(Cty).SendKeys(City);
        }
        public void InputZipcode(String ZipCode = "1234")
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(PostCde).SendKeys(ZipCode);
        }
        public void InputMobile(String MNum = "1111111111")
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(Mobile).SendKeys(MNum);
        }

        public void InputReference(String Reference = "aheey dhfjhd")
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(Refernce).SendKeys(Reference);
        }

        //public void Select

        public void ClickRegisterBtn()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(RegisterBtn).Click();
            Thread.Sleep(3000);
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
                // InputEmail(values[0]);
                // InputPw(values[0]);
                // ClickSubmitBtn();
                // Thread.Sleep(3000);

  
                INputEmail();
                // InputTitle();
                InputFirstName(values[0]);
                Thread.Sleep(1000);
                InputLastname(values[1]);
                Thread.Sleep(1000);
                InputPassW(values[2]);
                Thread.Sleep(1000);
                InputAddress(values[3]);
                Thread.Sleep(1000);
                InputCity(values[4]);
                Thread.Sleep(1000);
                selectState();
                Thread.Sleep(1000);
                InputZipcode(values[5]);
                Thread.Sleep(1000);
                InputMobile(values[6]);
                Thread.Sleep(1000);
                InputReference(values[7]);
                Thread.Sleep(1000);
                ClickRegisterBtn();

                _dash.ClickLogoutBtn();
            }
        }
    }
}


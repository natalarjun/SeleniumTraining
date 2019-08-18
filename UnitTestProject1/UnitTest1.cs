using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumJuly202019
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchGoogle()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("http://google.com");
            browser.FindElement(By.Name("q")).SendKeys("Mobile Legends" + Keys.Enter);
            browser.Close();
        }

        [TestMethod]
        public void CreateAnAccount()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("http://automationpractice.com");
            IWebElement signInLink = browser.FindElement(By.ClassName("login"));
            Thread.Sleep(5000);

            Assert.IsTrue(signInLink.Displayed);
            signInLink.Click();
        }

        [TestMethod]
        public void BrowseSite()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("http://automationpractice.com");
            Thread.Sleep(5000);
        }
    }
}
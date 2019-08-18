using NUnit.Framework;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Catch_Automation
{
    [TestFixture]
    class WithExtentReport
    {
        protected AventStack.ExtentReports.ExtentReports _extent;
        protected ExtentTest _test;

        [OneTimeSetUp]
        protected void Setup()
        {
            var dir = TestContext.CurrentContext.TestDirectory + "\\";
            var fileName = this.GetType().ToString() + ".html";
            var htmlReporter = new ExtentHtmlReporter(dir + fileName);

            _extent = new AventStack.ExtentReports.ExtentReports();
            _extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            _extent.Flush();
        }

        [SetUp]
        public void BeforeTest()
        {
            _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                    ? ""
                    : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }

            _test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            _extent.Flush();
        }


        [Test]
        public void PassingTest1()
        {
            IWebDriver browser = new ChromeDriver(@"C:\\Users\\Reg\\source\\repos\\testNUnit\\");
            browser.Url = "http://blog.testproject.io/";


            try
            {
                Assert.IsTrue(browser.Title.Contains("Blog"));
                _test.Pass("Assertion passed");
                _test.Log(Status.Pass, "Pass");
            }
            catch (AssertionException)
            {
                _test.Fail("Assertion failed");
                _test.Log(Status.Fail, "Fail");
                throw;
            }

            browser.Close();
        }

        [Test]
        public void PassingTest2()
        {
            IWebDriver browser = new ChromeDriver(@"C:\\Users\\Reg\\source\\repos\\testNUnit\\");
            browser.Url = "http://blog.testproject.io/";


            try
            {
                Assert.IsTrue(browser.Title.Contains("Blog"));
                _test.Pass("Assertion passed");
                _test.Log(Status.Pass, "Pass");
            }
            catch (AssertionException)
            {
                _test.Fail("Assertion failed");
                _test.Log(Status.Fail, "Fail");
                throw;
            }

            browser.Close();
        }

        [Test]
        public void PassingTest3()
        {
            IWebDriver browser = new ChromeDriver(@"C:\\Users\\Reg\\source\\repos\\testNUnit\\");
            browser.Url = "http://blog.testproject.io/";


            try
            {
                Assert.IsTrue(browser.Title.Contains("Blog"));
                _test.Pass("Assertion passed");
                _test.Log(Status.Pass, "Pass");
            }
            catch (AssertionException)
            {
                _test.Fail("Assertion failed");
                _test.Log(Status.Fail, "Fail");
                throw;
            }

            browser.Close();
        }

        [Test]
        public void PassingTest4()
        {
            IWebDriver browser = new ChromeDriver(@"C:\\Users\\Trainee\\Downloads\\testNUnit\\");
            browser.Url = "http://blog.testproject.io/";


            try
            {
                Assert.IsTrue(browser.Title.Contains("Blog"));
                _test.Pass("Assertion passed");
                _test.Log(Status.Pass, "Pass");
            }
            catch (AssertionException)
            {
                _test.Fail("Assertion failed");
                _test.Log(Status.Fail, "Fail");
                throw;
            }

            browser.Close();
        }

        [Test]
        public void FailedTest1()
        {
            IWebDriver browser = new ChromeDriver(@"C:\\Users\\Reg\\source\\repos\\testNUnit\\");
            browser.Url = "http://blog.testproject.io/";


            try
            {
                Assert.IsTrue(browser.Title.Contains("Rm"));
                _test.Pass("Assertion passed");
                _test.Log(Status.Pass, "Pass");
            }
            catch (AssertionException)
            {
                _test.Fail("Assertion failed");
                _test.Log(Status.Fail, "Fail");
                throw;
            }

            browser.Close();
        }

        [Test]
        public void FailedTest2()
        {
            IWebDriver browser = new ChromeDriver(@"C:\\Users\\Reg\\source\\repos\\testNUnit\\");
            browser.Url = "http://blog.testproject.io/";


            try
            {
                Assert.IsTrue(browser.Title.Contains("Rm"));
                _test.Pass("Assertion passed");
                _test.Log(Status.Pass, "Pass");
            }
            catch (AssertionException)
            {
                _test.Fail("Assertion failed");
                _test.Log(Status.Fail, "Fail");
                throw;
            }

            browser.Close();
        }
    }
}
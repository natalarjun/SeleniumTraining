using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1.lib
{
    public class MethodLib
    {
        public IWebDriver browser = new ChromeDriver(@"C:\\Users\\Trainee\\Downloads\\", ChromeOps());
        public string url = "http://automationpractice.com";

        public static ChromeOptions ChromeOps()
        {
            ChromeOptions options = new ChromeOptions();
            //starting here
            options.AddArguments("--incognito");
            options.AddArguments("test-type");
            options.AddArguments("--disable-extensions");
            options.AddArguments("--start-maximized");
            options.AddArguments("--disable-web-security");
            options.AddArguments("--allow-running-insecure-content");
            return options;
        }

        public static ChromeOptions HeadlessChromeOps()
        {
            ChromeOptions options = new ChromeOptions();
            //starting here
            options.AddArguments("--incognito");
            options.AddArguments("test-type");
            options.AddArguments("--disable-extensions");
            options.AddArguments("--start-maximized");
            options.AddArguments("--disable-web-security");
            options.AddArguments("--allow-running-insecure-content");
            return options;
        }

        public void InitializeBrowser()
        {
            browser.Navigate().GoToUrl(url);
        }
    }
}

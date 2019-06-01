using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumSandbox
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //create reference for browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to Google.com
            driver.Navigate().GoToUrl("http://www.google.com");

            //type a value into Google
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("careerdevs Providence");
             

        }
    }
}

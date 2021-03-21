using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using NUnit.Framework;
using System.Threading;


namespace NewFacebookTask
{
    [TestFixture]

    public class Class1
    {


        //[SetUp]
        //public void Initialize()
        //{
        //    IWebDriver driver = new ChromeDriver();

        //    driver.Navigate().GoToUrl("https://www.facebook.com/");
        //}
        //IWebDriver driver = new ChromeDriver();

        [Test]
        public void Registration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/"); // or driver.Url = “<URL>”;
            
            IWebElement element = driver.FindElement(By.Id("u_0_2_Ee"));
            element.Click();

            driver.FindElement(By.Name("firstName")).SendKeys("Mary");
            driver.FindElement(By.Name("lastName")).SendKeys("Mary");
            driver.Close();

        }

        //[TearDown]
        //public void Cleanup()
        //{
        //    driver.Close();
        //    Console.WriteLine("Close the browser");
        //}
    }
}

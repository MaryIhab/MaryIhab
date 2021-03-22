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


        [Test]
        public void Registration()
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.facebook.com/"); // or driver.Url = “<URL>”;
            
            IWebElement element = driver.FindElement(By.Id("u_0_2_Ee"));
            element.Click(); // SignUp

            driver.FindElement(By.Name("firstName")).SendKeys("Mary"); // FirstName
            driver.FindElement(By.Name("lastName")).SendKeys("Ihab"); // LastName
            driver.FindElement(By.Name("reg_email__")).SendKeys("testmail.com"); //Email
            driver.FindElement(By.Name("reg_passwd__")).SendKeys("P@ssw0rd"); // Password
            new SelectElement(driver.FindElement(By.Name("birthday_day"))).SelectByValue("5"); //Birth Day                                                                                                            // Birthday
            new SelectElement(driver.FindElement(By.Name("birthday_month"))).SelectByValue("Feb"); //Birth month
            new SelectElement(driver.FindElement(By.Name("birthday_year"))).SelectByValue("2000"); // Birth year
            driver.FindElement(By.Id("u_e_4_hm")).Click(); // Gender
            driver.FindElement(By.Name("websubmit")).Click(); // Submit

            driver.Close();
        }



        [Test]
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/"); // or driver.Url = “<URL>”;

            driver.FindElement(By.Name("email")).SendKeys("testmail.com"); //Email
            driver.FindElement(By.Name("pass")).SendKeys("P@ssw0rd"); // Password

            driver.FindElement(By.Name("login")).Click(); // Login

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

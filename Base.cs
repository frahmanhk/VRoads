using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Roads
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            //Driver Initialise
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
           
        }

        [Test]
        public void LaunchBrowser()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.vicroads.vic.gov.au/registration/limited-use-permits/unregistered-vehicle-permits");
            System.Threading.Thread.Sleep(3000);
        }
    }
}
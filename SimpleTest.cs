using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumDemo
{
    public class SimpleTest
    {
        [Test]
        public void BodyElementIsVisible()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless=new");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");

            using var driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://www.accountplusfinance.com/education/bonds");

            // Wait up to 10 seconds for <body> to be present and visible
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var body = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName("body")));

            bool isVisible = body.Displayed;

            TestContext.WriteLine("BODY VISIBLE: " + isVisible);
            Assert.IsTrue(isVisible, "The <body> element did not load or is not visible.");
        }
    }
}


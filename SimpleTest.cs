using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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

            driver.Navigate().GoToUrl("https://www.accountplusfinance.com/education/futures");

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Wait for <body> to exist and be displayed
            var body = wait.Until(d =>
            {
                var element = d.FindElement(By.TagName("body"));
                return element.Displayed ? element : null;
            });

            TestContext.WriteLine("BODY VISIBLE: " + body.Displayed);
            Assert.That(body.Displayed, Is.True, "<body> element is not visible");
        }
    }
}

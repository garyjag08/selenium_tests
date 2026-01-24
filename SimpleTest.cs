using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo
{
    public class SimpleTest
    {
        [Test]
        public void PrintTitle()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless=new");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");

            using var driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://example.com");
            string title = driver.Title;

            TestContext.WriteLine("TITLE: " + title);
        }
    }
}


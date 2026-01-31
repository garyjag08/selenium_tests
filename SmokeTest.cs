using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumDemo
{
    public class SmokeTest
    {
        private IWebDriver _driver;
        private DriverFactory _factory;
        private SmokeTest _smoke;

        [SetUp]
        public void SetUp()
        {
            _factory = new DriverFactory();
            _smoke = new SmokeTest();

            _driver = _factory.CreateChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void BodyElementIsVisible()
        {
            bool result = _smoke.IsBodyVisible(
                _driver,
                "https://www.accountplusfinance.com/education/futures"
            );

            Assert.That(result, Is.True, "Smoke test failed: <body> was not visible.");
        }
    }
}


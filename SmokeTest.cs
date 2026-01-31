using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumDemo
{
    public class SmokeTest
    {
        public bool IsBodyVisible(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                var body = wait.Until(d =>
                {
                    var element = d.FindElement(By.TagName("body"));
                    return element.Displayed ? element : null;
                });

                return body.Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
}

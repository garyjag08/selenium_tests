using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo{
  public class DriverFactory {
    public IWebDriver CreateChromeDriver(){
        var options = new ChromeOptions();
        options.AddArgument("--headless=new");
        options.AddArgument("--no-sandbox");
       options.AddArgument("--disable-dev-shm-usage");
      var driver = new ChromeDriver(options);
      return driver; 
    } // InitializeDriver      
  }
}

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;

namespace Portfolio.Driver

{
    internal class BrowserFactory
    {
        public static IWebDriver GetBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    var options = new ChromeOptions();
                    options.AddAdditionalCapability("useAutomationExtension", false);
                    options.AddExcludedArgument("enable-automation");
                    options.AddUserProfilePreference("credentials_enable_service", false);
                    return new ChromeDriver(options);
                case BrowserType.Firefox:
                    return new FirefoxDriver();
                case BrowserType.Edge:
                    return new EdgeDriver();
                case BrowserType.Opera:
                    return new OperaDriver();
                case BrowserType.InternetExplorer:
                    return new InternetExplorerDriver();
                default:
                    throw new Exception("Unknown browser type!");
            }
        }
    }
}
using OpenQA.Selenium;

namespace Portfolio.Driver
{
    public class DriverManager
    {
        private static IWebDriver _driver;

        public static IWebDriver GetWebDriver()
        {
            if (_driver == null)
            {
                _driver = BrowserFactory.GetBrowser(BrowserType.Chrome);
            }

            return _driver;
        }

        public static void DisposeDriver()
        {
            _driver.Close();
            _driver.Quit();
            _driver = null;
        }
    }
}
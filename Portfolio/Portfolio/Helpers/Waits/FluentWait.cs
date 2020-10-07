using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Portfolio.Driver;
using System;

namespace Portfolio.Helpers.Waits
{
    public class FluentWait
    {
        private readonly IWebDriver _driver;

        public FluentWait()
        {
            _driver = DriverManager.GetWebDriver();
        }

        public FluentWait WaitForElement(int timeout, int interval, By elementLocator)
        {
            var fluentWait = new DefaultWait<IWebDriver>(_driver)
            {
                Timeout = TimeSpan.FromSeconds(timeout),
                PollingInterval = TimeSpan.FromMilliseconds(interval)
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Until(x => x.FindElement(elementLocator).Displayed);
            return this;
        }

        public FluentWait WaitForElementNotVisible(int timeout, int interval, By elementLocator)
        {
            var fluentWait = new DefaultWait<IWebDriver>(_driver)
            {
                Timeout = TimeSpan.FromSeconds(timeout),
                PollingInterval = TimeSpan.FromMilliseconds(interval)
            };
            fluentWait.Until(driver =>
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(interval - 1);
                try
                {
                    driver.FindElement(elementLocator);
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
                return false;
            });
            return this;
        }

        public FluentWait WaitForElementAndClick(int timeout, int interval, By elementLocator)
        {
            var fluentWait = new DefaultWait<IWebDriver>(_driver)
            {
                Timeout = TimeSpan.FromSeconds(timeout),
                PollingInterval = TimeSpan.FromMilliseconds(interval)
            };
            fluentWait.Until(driver =>
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(interval - 1);
                try
                {
                    driver.FindElement(elementLocator).Click();
                }
                catch (ElementClickInterceptedException)
                {
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
                return false;
            });
            return this;
        }

        public FluentWait WaitForAjaxExecute(int timeout, int interval)
        {
            var fluentWait = new DefaultWait<IWebDriver>(_driver)
            {
                Timeout = TimeSpan.FromSeconds(timeout),
                PollingInterval = TimeSpan.FromMilliseconds(interval)
            };
            fluentWait.Until(driver =>
                (bool)
                ((IJavaScriptExecutor)driver).ExecuteScript($"return jQuery.active === 0"));
            return this;
        }
    }
}

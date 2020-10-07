using OpenQA.Selenium;
using Portfolio.Driver;

namespace Portfolio.Helpers.BaseClasses
{
    public abstract class PageBase
    {
        protected IWebDriver Driver;

        public PageBase()
        {
            Driver = DriverManager.GetWebDriver();
        }
    }
}

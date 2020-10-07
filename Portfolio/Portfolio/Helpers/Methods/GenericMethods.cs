using OpenQA.Selenium;
using Portfolio.Helpers.BaseClasses;
using System;

namespace Portfolio.Helpers.Methods
{
    public static class GenericMethods
    {
        public static T Click<T>(this T page, IWebElement element) where T : PageBase
        {
            element.Click();
            return page;
        }

        public static T SendKeys<T>(this T page, IWebElement element, string text) where T : PageBase
        {
            element.Clear();
            element.SendKeys(text);
            return page;
        }
    }
}

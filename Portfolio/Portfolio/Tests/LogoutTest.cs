using NUnit.Framework;
using OpenQA.Selenium;
using Portfolio.Helpers.BaseClasses;
using Portfolio.Helpers.Methods;
using Portfolio.Helpers.Waits;
using Portfolio.PageObject;

namespace Portfolio.Tests
{
    public class LogoutTest : TestBase
    {
        [Test, Order(1)]
        public void Logout()
        {
            new Login().SuccessfulLogin();

            new MainPage().ClickLogoutButton();

            new FluentWait().WaitForElement(5, 250, By.XPath("//app-notification[@class='ng-star-inserted']"));

            Assert.IsTrue(Driver.FindElement(By.Id("Login")).Displayed);
        }
    }
}

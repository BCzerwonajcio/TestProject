using NUnit.Framework;
using OpenQA.Selenium;
using Portfolio.Helpers.BaseClasses;
using Portfolio.Helpers.Methods;
using Portfolio.Helpers.Waits;
using Portfolio.PageObject;

namespace Portfolio.Tests
{
    public class LoginTests : TestBase
    {
        [Test, Order(1)]
        public void SuccessfulLogin()
        {
            new Login().SuccessfulLogin();

            Assert.IsTrue(Driver.FindElement(By.Id("btnLogout")).Displayed);
        }

        [Test, Order(2)]
        public void FaildLogin()
        {
            new LoginPage().SetIntoLoginField("xxx")
                           .SetIntoPasswordField("xxx")
                           .ClickOnLoginButton();

            new FluentWait().WaitForElement(5, 250, By.XPath("//app-notification[@class='ng-star-inserted']"));

            Assert.IsTrue(Driver.FindElement(By.Id("Login")).Displayed);
        }
    }
}

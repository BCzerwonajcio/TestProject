using OpenQA.Selenium;
using Portfolio.Helpers.BaseClasses;
using Portfolio.Helpers.Other;
using Portfolio.Helpers.Waits;
using Portfolio.PageObject;

namespace Portfolio.Helpers.Methods
{
    public class Login : PageBase
    {
        public void SuccessfulLogin()
        {
            var loginPage = new LoginPage();
            loginPage.SetIntoLoginField(Credentials.Login)
                     .SetIntoPasswordField(Credentials.Password)
                     .ClickOnLoginButton();

            new FluentWait().WaitForElement(5, 250, By.XPath("//app-notification[@class='ng-star-inserted']/child::div[contains(@class, 'notification__text')]/child::span"));
        }

        public void NavigateToDevUrlAndLogin(ref IWebDriver webDriverReference)
        {
            webDriverReference.Navigate().GoToUrl(DeployEnvironent.DEV);
            SuccessfulLogin();
        }

        public void NavigateToQasUrlAndLogin(ref IWebDriver webDriverReference)
        {
            webDriverReference.Navigate().GoToUrl(DeployEnvironent.QAS);
            SuccessfulLogin();
        }
    }
}
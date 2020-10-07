using OpenQA.Selenium;
using Portfolio.Helpers.BaseClasses;
using Portfolio.Helpers.Methods;

namespace Portfolio.PageObject
{
    public class LoginPage : PageBase
    {
        private IWebElement TxtLogin => 
            Driver.FindElement(By.Id("Login"));
        private IWebElement TxtPassword => 
            Driver.FindElement(By.Id("Password"));
        private IWebElement BtnLogin => 
            Driver.FindElement(By.XPath("//button[@type='submit']"));
        private IWebElement BtnChangePassword => 
            Driver.FindElement(By.XPath("//span[@class='mat-button-wrapper']"));
        private IWebElement TxtOldPassword => 
            Driver.FindElement(By.XPath("//input[@formcontrolname='oldPassword']"));
        private IWebElement TxtNewPassword => 
            Driver.FindElement(By.XPath("//input[@formcontrolname='Password']"));
        private IWebElement TxtNewPasswordConfirm => 
            Driver.FindElement(By.XPath("//input[@formcontrolname='confirmPassword']"));
        private IWebElement BtnChange => 
            Driver.FindElement(By.XPath("//button[contains(@class, 'mat-button-base mat-primary']"));


        public LoginPage SetIntoLoginField(string login) => 
            GenericMethods.SendKeys(this, TxtLogin, login);

        public LoginPage SetIntoPasswordField(string password) => 
            GenericMethods.SendKeys(this, TxtPassword, password);

        public MainPage ClickOnLoginButton() => 
            GenericMethods.Click(new MainPage(), BtnLogin);
    }
}

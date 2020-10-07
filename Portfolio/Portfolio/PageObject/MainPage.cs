using OpenQA.Selenium;
using Portfolio.Helpers.BaseClasses;
using Portfolio.Helpers.Methods;

namespace Portfolio.PageObject
{
    public class MainPage : PageBase
    {
        private IWebElement BtnMenuLogout => 
            Driver.FindElement(By.Id("btnLogout"));
        private IWebElement BtnMenuUsers => 
            Driver.FindElement(By.Id("btnUsers"));

        public MainPage ClickLogoutButton() => 
            GenericMethods.Click(this, BtnMenuLogout);
        public FormPage ClickUsersButton() => 
            GenericMethods.Click(new FormPage(), BtnMenuUsers);
    }
}

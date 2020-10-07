using OpenQA.Selenium;
using Portfolio.Helpers.BaseClasses;
using Portfolio.Helpers.Methods;

namespace Portfolio.PageObject
{
    public class UsersPage : PageBase
    {
        private IWebElement BtnAddUser => 
            Driver.FindElement(By.CssSelector("button > span > i-feather[name='add']"));

        public UsersPage ClickAddUserButton() => 
            GenericMethods.Click(this, BtnAddUser);
    }
}

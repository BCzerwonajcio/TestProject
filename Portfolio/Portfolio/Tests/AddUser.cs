using NUnit.Framework;
using OpenQA.Selenium;
using Portfolio.Helpers.BaseClasses;
using Portfolio.Helpers.Other;
using Portfolio.Helpers.Waits;
using Portfolio.PageObject;

namespace Portfolio.Tests
{
    public class AddUser : TestBaseWithLogin
    {
        [Test, Order(1)]
        public void AddNewUser()
        {
            var mainPage = new MainPage();
            mainPage.ClickUsersButton();

            new UsersPage().ClickAddUserButton();


            new FluentWait().WaitForElement(5, 250, By.Id("FirstName"));

            var nameGenerator = new NameGenerator();
            var firstname = nameGenerator.RandomFirstnameGenerator();

            var randomGenerator = new Bogus.Randomizer();

            var fakeGenerator = new Bogus.Faker();

            var formPage = new FormPage();
            formPage.SetIntoFirstNameField(firstname)
                    .SetIntoLastNameField(nameGenerator.RandomLastNameGenerator())
                    .SetIntoEmailField($"{randomGenerator.Replace("??*****").ToLower()}@gmail.com")
                    .SetIntoPhonNumberField(randomGenerator.ReplaceNumbers("#########"))
                    .SetIntoCityField(randomGenerator.EnumValues<Localization>().ToString())
                    .SetIntoPostcode($"{randomGenerator.ReplaceNumbers("###")}-{randomGenerator.ReplaceNumbers("##")}")
                    .SetIntoStreetField(fakeGenerator.Address.StreetName())
                    .SetIntoHouseNumberField(randomGenerator.Number(100).ToString())
                    .ClickAddButton();

            new FluentWait().WaitForElement(5, 250, By.CssSelector("button > span > i-feather[name='add']"));

            Assert.True(Driver.FindElement(By.XPath($"//td[contains(text(),'{firstname}')]")).Displayed);
        }
    }
}

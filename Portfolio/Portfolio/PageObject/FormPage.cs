using OpenQA.Selenium;
using Portfolio.Helpers.BaseClasses;
using Portfolio.Helpers.Methods;

namespace Portfolio.PageObject
{
    public class FormPage : PageBase
    {
        private IWebElement TxtFirstName => 
            Driver.FindElement(By.Id("FirstName"));
        private IWebElement TxtLastName => 
            Driver.FindElement(By.Id("LastName"));
        private IWebElement TxtEmail => 
            Driver.FindElement(By.Id("Email"));
        private IWebElement TxtPhoneNumber => 
            Driver.FindElement(By.Id("phoneNumber"));
        private IWebElement TxtCity => 
            Driver.FindElement(By.Id("City"));
        private IWebElement TxtPostcode => 
            Driver.FindElement(By.Id("Code"));
        private IWebElement TxtStreet => 
            Driver.FindElement(By.Id("Street"));
        private IWebElement TxtHouseNumber => 
            Driver.FindElement(By.Id("houseNumber"));
        private IWebElement BtnAdd => 
            Driver.FindElement(By.Id("btn__add"));
        private IWebElement BtnCancel => 
            Driver.FindElement(By.Id("btn__cancel"));

        public FormPage SetIntoFirstNameField(string firstName) => 
            GenericMethods.SendKeys(this, TxtFirstName, firstName);

        public FormPage SetIntoLastNameField(string lastName) => 
            GenericMethods.SendKeys(this, TxtLastName, lastName);

        public FormPage SetIntoEmailField(string email) => 
            GenericMethods.SendKeys(this, TxtEmail, email);

        public FormPage SetIntoPhonNumberField(string phoneNumber) => 
            GenericMethods.SendKeys(this, TxtPhoneNumber, phoneNumber);

        public FormPage SetIntoCityField(string city) => 
            GenericMethods.SendKeys(this, TxtCity, city);

        public FormPage SetIntoPostcode(string postcode) => 
            GenericMethods.SendKeys(this, TxtPostcode, postcode);

        public FormPage SetIntoStreetField(string street) => 
            GenericMethods.SendKeys(this, TxtStreet, street);

        public FormPage SetIntoHouseNumberField(string houseNumber) => 
            GenericMethods.SendKeys(this, TxtHouseNumber, houseNumber);

        public FormPage ClickAddButton() => 
            GenericMethods.Click(this, BtnAdd);

        public FormPage ClickCancelButton() => 
            GenericMethods.Click(this, BtnCancel);
    }
}

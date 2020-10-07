using NUnit.Framework;
using OpenQA.Selenium;
using Portfolio.Driver;
using Portfolio.Helpers.Methods;
using System;

namespace Portfolio.Helpers.BaseClasses
{
    public abstract class TestBase
    {
        protected IWebDriver Driver;

        [SetUp]
        public virtual void BeforeTest()
        {
            Driver = DriverManager.GetWebDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterTest()
        {
            DriverManager.DisposeDriver();
        }
    }

    public abstract class TestBaseWithLogin : TestBase
    {
        [SetUp]
        public override void BeforeTest()
        {
            base.BeforeTest();

            Credentials.CredentialConfiguration();

            new Login().NavigateToDevUrlAndLogin(ref Driver);
        }
    }
}

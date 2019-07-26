using OpenQA.Selenium;
using Selenium.UITestAutomation.Fixture;
using Selenium.UITestAutomation.PageObject;
using System;
using System.Threading;
using Xunit;

namespace Selenium.UITestAutomation
{
    [Collection("Chrome Driver")]
    public class WhenNavigateToHomeNotLogged
    {
        private IWebDriver driver;

        public WhenNavigateToHomeNotLogged(TestClassFixture fixture)
        {
            this.driver = fixture.Driver;
        }

        [Fact]
        public void AndClickOnSignInButton()
        {
            //arrange
            var homeNotLogged = new WhenNavigateToHomeNotLoggedPO(driver);

            //act
            homeNotLogged.Navigate();
            homeNotLogged.LogIn();

            //asset
            Thread.Sleep(5000);
        }
    }
}

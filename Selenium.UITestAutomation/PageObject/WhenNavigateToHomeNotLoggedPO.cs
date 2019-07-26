using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium.UITestAutomation.PageObject
{
    public class WhenNavigateToHomeNotLoggedPO
    {
        private IWebDriver driver;
        By bySignIn;

        public WhenNavigateToHomeNotLoggedPO(IWebDriver driver)
        {
            this.driver = driver;
            bySignIn = By.ClassName("a.login");
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void LogIn()
        {
            driver.FindElement(bySignIn).Click();
        }
    }
}

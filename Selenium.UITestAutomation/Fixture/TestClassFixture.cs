using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.UITestAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.UITestAutomation.Fixture
{
    public class TestClassFixture : IDisposable
    {
        public IWebDriver Driver { get; set; }

        public TestClassFixture()
        {
            Driver = new ChromeDriver(TestHelper.GetAssemblyPath());
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}

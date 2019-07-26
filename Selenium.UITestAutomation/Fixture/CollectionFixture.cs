using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Selenium.UITestAutomation.Fixture
{
    [CollectionDefinition("Chrome Driver")]
    public class CollectionFixture : ICollectionFixture<TestClassFixture>
    {
    }
}

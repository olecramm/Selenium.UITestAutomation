using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Selenium.UITestAutomation.Helpers
{
    public class TestHelper
    {
        public static string GetAssemblyPath() => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}

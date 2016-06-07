using BehaviouralTest.WebUI.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SearchServiceTest
{
    [Binding]
    
    public sealed class WebUIHookUps
    {
        [AfterTestRun]
        public static void QuitWebDriver()
        {
            Driver.Quit();
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Driver.Initialize();
        }

        [AfterScenario]
        public static void AfterScenario()
        {

            Driver.Close();
        }
    }
}

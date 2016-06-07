using BehaviouralTest.WebUI.Framework;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SearchServiceTest.StepDefinitions
{
    [Binding]
    [Parallelizable]
    public sealed class StepDefinition1
    {
        [Given(@"I navigated to the page ""(.*)""")]
        public void GivenINavigatedToThePage(string p0)
        {
            DriverNavigation.Navigate(URL: p0);
        }

        [Given(@"I see page was loaded")]
        public void GivenISeePageWasLoaded()
        {
            Driver.WebDriverInstance.Title.Should().NotBeNullOrEmpty();
        }

    }
}

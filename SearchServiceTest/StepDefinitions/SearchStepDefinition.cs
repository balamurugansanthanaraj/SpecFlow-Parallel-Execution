using BehaviouralTest.WebUI.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using FluentAssertions;
using NUnit.Framework;

namespace SearchServiceTest.StepDefinitions
{
    [Binding]
     [Parallelizable]
    public sealed class SearchStepDefinition
    {
        [Given(@"I navigate to the page ""(.*)""")]
        public void GivenINavigateToThePage(string p0)
        {
            DriverNavigation.Navigate(URL: p0);
        }

        [Given(@"I see page is loaded")]
        public void GivenISeePageIsLoaded()
        {
            Driver.WebDriverInstance.Title.Should().NotBeNullOrEmpty();
           // Driver.WebDriverInstance.Title.Should().Be("Google");
        }

        [When(@"I enter search keyword in search Testbox")]
        public void WhenIEnterSearchKeywordInSearchTestbox(Table table)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I click search button")]
        public void WhenIClickSearchButton()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"I should see search keyword related results")]
        public void ThenIShouldSeeSearchKeywordRelatedResults()
        {
           // ScenarioContext.Current.Pending();
        }


    }
}

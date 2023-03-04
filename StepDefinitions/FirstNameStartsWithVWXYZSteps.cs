using Demo_DotNet.Helpers;
using DigitalAutomationQuoteTest.AutomationFramework.PageObjects;
using DigitalAutomationQuoteTest.Extensions;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DigitalAutomationQuoteTest.StepDefinitions
{
    [Binding]
    public sealed class FirstNameStartsWithVWXYZSteps
    {
        private readonly ScenarioContext scenarioContext;

        public FirstNameStartsWithVWXYZSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        private AutomationTechTestLandingPage AutomationTechTestLandingPage { get { return new AutomationTechTestLandingPage(this.scenarioContext.Driver()); } }

        [When(@"I '(.*)' click on getting started button option")]
        public void WhenIClickOnGettingStartedButtonOption(string fname)
        {
            if (fname.ToUpper().StartsWith("V") || fname.ToUpper().StartsWith("W") || fname.ToUpper().StartsWith("X") || fname.ToUpper().StartsWith("Y") || fname.ToUpper().StartsWith("Z"))
            {
                Wait.Until(TimeSpan.FromSeconds(20), () => this.AutomationTechTestLandingPage.GettingStartedButton.Displayed);
                this.AutomationTechTestLandingPage.GettingStartedButton.Click();
            }
            else
            {
                Console.WriteLine("FIRST NAME DOES NOT Start With Letter V_W_X_Y_Z");
                Assert.True(1 == 2);
            }
        }

        [Then(@"< Back to Editor button should appear")]
        public void ThenBackToEditorButtonShouldAppear()
        {
            Wait.Until(TimeSpan.FromSeconds(20), () => this.AutomationTechTestLandingPage.BackGettingStartedButton.Displayed);
            Assert.IsTrue(this.AutomationTechTestLandingPage.BackGettingStartedButton.Displayed);
        }


    }
}

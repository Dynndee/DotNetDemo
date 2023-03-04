using Demo_DotNet.Helpers;
using DigitalAutomationQuoteTest.AutomationFramework.PageObjects;
using DigitalAutomationQuoteTest.Extensions;

using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DigitalAutomationQuoteTest.StepDefinitions
{
    [Binding]
    public sealed class FirstNameStartWithLMNOPSteps
    {
        private readonly ScenarioContext scenarioContext;

        public FirstNameStartWithLMNOPSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        private AutomationTechTestLandingPage AutomationTechTestLandingPage { get { return new AutomationTechTestLandingPage(this.scenarioContext.Driver()); } }

        [When(@"I '(.*)' click on < button  option")]
        public void WhenIOnButtonOption(string fname)
        {
            if (fname.ToUpper().StartsWith("L") || fname.ToUpper().StartsWith("M") || fname.ToUpper().StartsWith("N") || fname.ToUpper().StartsWith("O") || fname.ToUpper().StartsWith("P"))
            {
                Wait.Until(TimeSpan.FromSeconds(20), () => this.AutomationTechTestLandingPage.SignButton.Displayed);
                this.AutomationTechTestLandingPage.SignButton.Click();
            }
            else
            {
                Console.WriteLine("FIRST NAME DOES NOT Start With Letter L_M_N_O_P");
                Assert.True(1 == 2);
            }

        }


        [Then(@"option panel is hidden")]
        public void ThenOptionPanelIsHidden()
        {
            Wait.Until(TimeSpan.FromSeconds(20), () => this.AutomationTechTestLandingPage.OptionsLabel.Displayed);
            var optiondisplay = this.AutomationTechTestLandingPage.OptionsLabel.Displayed;
            Assert.IsFalse(optiondisplay);
        }



    }
}

using Demo_DotNet.Helpers;
using DigitalAutomationQuoteTest.AutomationFramework.PageObjects;
using DigitalAutomationQuoteTest.Extensions;

using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DigitalAutomationQuoteTest.StepDefinitions
{
    [Binding]
    public sealed class FirstNameStartsWithQRSTUSteps
    {
        private readonly ScenarioContext scenarioContext;

        public FirstNameStartsWithQRSTUSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        private AutomationTechTestLandingPage AutomationTechTestLandingPage { get { return new AutomationTechTestLandingPage(this.scenarioContext.Driver()); } }


        [When(@"'(.*)' click  save button")]
        public void WhenClickSaveButton(string fname)
        {
            if (fname.ToUpper().StartsWith("Q") || fname.ToUpper().StartsWith("R") || fname.ToUpper().StartsWith("S") || fname.ToUpper().StartsWith("T") || fname.ToUpper().StartsWith("U"))
            {
                Wait.Until(TimeSpan.FromSeconds(10), () => this.AutomationTechTestLandingPage.SaveButton.Displayed);
                this.AutomationTechTestLandingPage.SaveButton.Click();
            }
            else
            {
                Console.WriteLine("FIRST NAME DOES NOT Start With Letter Q_R_S_T_U");
                Assert.True(1 == 2);
            }

        }
        [Then(@"log in window should appear")]
        public void ThenLogInWindowShouldAppear()
        {
            Wait.Until(TimeSpan.FromSeconds(20), () => this.AutomationTechTestLandingPage.WindowLoginText.Displayed);
            var mssg = this.AutomationTechTestLandingPage.WindowLoginText.Text;
            Assert.IsTrue(this.AutomationTechTestLandingPage.WindowLoginText.Displayed);
            Assert.AreEqual("Log in",mssg);
        }


    }
}

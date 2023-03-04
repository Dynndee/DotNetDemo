using Demo_DotNet.Helpers;
using DigitalAutomationQuoteTest.AutomationFramework.PageObjects;
using DigitalAutomationQuoteTest.Extensions;
using NUnit.Framework;

namespace DigitalAutomationQuoteTest.StepDefinitions
{
    [Binding]
    public sealed class FirstNameStartsWithFGHIJKSteps
    {
        private readonly ScenarioContext scenarioContext;
        public FirstNameStartsWithFGHIJKSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        private AutomationTechTestLandingPage AutomationTechTestLandingPage { get { return new AutomationTechTestLandingPage(this.scenarioContext.Driver()); } }

        [When(@"'(.*)' click share button")]
        public void WhenClickShareButton(string fname)
        {
            if (fname.ToUpper().StartsWith("F") || fname.ToUpper().StartsWith("G") || fname.ToUpper().StartsWith("H") || fname.ToUpper().StartsWith("I") || fname.ToUpper().StartsWith("J") || fname.ToUpper().StartsWith("K"))
            {
                this.AutomationTechTestLandingPage.SaveButton.Click();
                Wait.Until(TimeSpan.FromSeconds(20), () => this.AutomationTechTestLandingPage.AppLink.Displayed);
                var lnkdispl = this.AutomationTechTestLandingPage.AppLink.Displayed;
                Assert.IsTrue(lnkdispl);
            }
            else
            {
                Console.WriteLine("FIRST NAME DOES NOT Start With Letter F_G_H_I_J_K");
                Assert.True(1 == 2);
            }
        }

        [Then(@"I should see link https://dotnetfiddle\.net/")]
        public void ThenIShouldSeeLinkHttpsDotnetfiddle_Net()
        {
            Wait.Until(TimeSpan.FromSeconds(20), () => this.AutomationTechTestLandingPage.AppLink.Displayed);
            var lnkdispl = this.AutomationTechTestLandingPage.AppLink.Displayed;
            Wait.Until(TimeSpan.FromSeconds(20), () => this.AutomationTechTestLandingPage.AppLink.Enabled);
            var lnkenbl = this.AutomationTechTestLandingPage.AppLink.Enabled;
            Assert.IsTrue(lnkdispl);
            Assert.IsTrue(lnkenbl);
            var txtcontent = this.AutomationTechTestLandingPage.AppLink.GetAttribute("textContent");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine(txtcontent);
            Console.WriteLine("--------------------------------------------------------------------");

        }

    }
}
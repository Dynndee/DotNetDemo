using DigitalAutomationQuoteTest.AutomationFramework.PageObjects;
using DigitalAutomationQuoteTest.Extensions;
using NUnit.Framework;

namespace DigitalAutomationQuoteTest.StepDefinitions
{
    [Binding]
    public sealed class FirstNameStartsWithABCDESteps
    {
        private readonly ScenarioContext scenarioContext;

        public FirstNameStartsWithABCDESteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        private AutomationTechTestLandingPage AutomationTechTestLandingPage { get { return new AutomationTechTestLandingPage(this.scenarioContext.Driver()); } }

        [Given(@"I set '(.*)' in the input box")]
        public void GivenISetInTheInputBox(string fname)
        {
            this.AutomationTechTestLandingPage.WithFirstname(fname);
        }


        [Given(@"'(.*)' starts with letter A-B-C-D-E with NUnit set for NuGet Packages")]
        public void GivenStartsWithLetterA_B_C_D_EWithNUnitSetForNuGetPackages(string fname)
        {
            if (fname.ToUpper().StartsWith("A") || fname.ToUpper().StartsWith("B") || fname.ToUpper().StartsWith("C") || fname.ToUpper().StartsWith("D") || fname.ToUpper().StartsWith("D"))
            {
                this.AutomationTechTestLandingPage.WithNPackagename("NUnit");
                Assert.True(this.AutomationTechTestLandingPage.IsNugetPackageDisplayed);
            }
            else
            {
                Console.WriteLine("FIRST NAME DOES NOT Start With Letter A_B_C_D_E");
                Assert.True(1 == 2);
            }
        }


        [Then(@"I should see Package added")]
        public void ThenIShouldSeePackageAdded()
        {
            Assert.True(this.AutomationTechTestLandingPage.IsNugetPackageDisplayed);
        }





    }
}

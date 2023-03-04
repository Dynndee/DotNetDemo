using DigitalAutomationQuoteTest.AutomationFramework;
using DigitalAutomationQuoteTest.AutomationFramework.PageObjects;
using DigitalAutomationQuoteTest.Extensions;
using DigitalAutomationQuoteTest.Selenium;
using TechTalk.SpecFlow;

namespace DigitalAutomationQuoteTest.Hooks
{
    [Binding]
    public sealed class ScenarioHooks
    {
        private readonly ScenarioContext scenarioContext;

        public ScenarioHooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

           private AutomationTechTestLandingPage AutomationTechTestLandingPage { get { return new AutomationTechTestLandingPage(this.scenarioContext.Driver()); } }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var driver = WebDriver.NewInstance();
            this.scenarioContext.Driver(driver);
            this.AutomationTechTestLandingPage.LoadPage();
        }

        [AfterScenario(Order = 1001)]
        public void AfterScenario()
        {
          this.scenarioContext.Driver().Close();
          this.scenarioContext.Driver().Quit();

        }
    }
}

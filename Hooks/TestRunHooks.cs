using AutomationPracticeTest.Extensions;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace DigitalAutomationQuoteTest.Hooks
{
    [Binding]
    public sealed class TestRunHooks
    {

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Dictionary<string, string> dictstr = new Dictionary<string, string>()
            {
            
                 {"baseUrl","https://dotnetfiddle.net/" },
                {"browser","Chrome" },
                {"headless","false" }
            };

            AutomationProperties.DigitalUrl = dictstr["baseUrl"];
            AutomationProperties.Browser = dictstr["browser"];
            AutomationProperties.Headless = dictstr["headless"];

        }

    }
}

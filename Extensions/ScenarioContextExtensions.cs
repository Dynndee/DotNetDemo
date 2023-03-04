using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace DigitalAutomationQuoteTest.Extensions
{
    public static class ScenarioContextExtensions
    {
        private const string DriverKey = "driver";
        

        public static IWebDriver Driver(this ScenarioContext that)
        {
            return that.Get<IWebDriver>(ScenarioContextExtensions.DriverKey);
        }

        public static void Driver(this ScenarioContext that, IWebDriver driver)
        {
            that.Set(driver, ScenarioContextExtensions.DriverKey);
        }


       
    }
}

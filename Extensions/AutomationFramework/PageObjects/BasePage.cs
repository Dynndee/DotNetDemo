using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DigitalAutomationQuoteTest.AutomationFramework.PageObjects
{
    public abstract class BasePage
    {
        protected BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        protected IWebDriver Driver { get; private set; }

    }
}

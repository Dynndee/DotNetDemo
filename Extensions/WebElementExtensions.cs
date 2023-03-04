using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalAutomationQuoteTest.Extensions
{
    public static class WebElementExtensions
    {

        public static void ForceClick(this IWebElement that)
        {
            that.SendKeys(Keys.Enter);
        }

        public static void EnterText(this IWebElement that, string text, bool shouldClear = true)
        {
            if (shouldClear)
            {
                that.Clear();
            }

            that.SendKeys(text);
        }



        public static void Hover(this IWebElement that, IWebDriver driver)
        {
            var actions = new Actions(driver);
            actions.MoveToElement(that).Perform();
        }

    }
}

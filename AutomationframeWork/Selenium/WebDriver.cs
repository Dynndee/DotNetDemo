using DigitalAutomationQuoteTest.AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using DigitalAutomationQuoteTest.Extensions;
using System;


namespace DigitalAutomationQuoteTest.Selenium
{
    public class WebDriver
    {
        public static IWebDriver NewInstance()
        {
            var instance = NewLocalDriver();
            return instance;
        }

        private static IWebDriver NewLocalDriver()
        {
           var headless = Convert.ToBoolean(AutomationProperties.Headless);
            switch (AutomationProperties.Browser.ToUpper())
            {
                case "CHROME":
                //    System.setProperty("webdriver.chrome.driver", "C://chromedriver.exe");
                    var chromeOptions = new ChromeOptions();

                    if (headless)
                    {
                        chromeOptions.AddArgument("--headless");
                    }
       
                    chromeOptions.AddArguments("disable-infobars");
                    chromeOptions.AddArgument("--start-maximized");
                    chromeOptions.AddArgument("--ignore-certificate-errors");
                    chromeOptions.AddArgument("--disable-popup-blocking");
                    chromeOptions.AddArgument("--incognito");
                    return new ChromeDriver(chromeOptions);
  

                case "IE":
                    var internetExplorerOptions = new InternetExplorerOptions();
                    internetExplorerOptions.EnsureCleanSession = true;
                    internetExplorerOptions.IgnoreZoomLevel = true;
                    internetExplorerOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    return new InternetExplorerDriver(internetExplorerOptions);

                default:
                    throw new ArgumentException("Specified an invalid browser");
            }
        }
    }
}

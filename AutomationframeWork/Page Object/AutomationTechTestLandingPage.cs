using Demo_DotNet.Helpers;
using DigitalAutomationQuoteTest.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalAutomationQuoteTest.AutomationFramework.PageObjects
{
    public class AutomationTechTestLandingPage : BasePage
    {
        private const string Title = "Online Compiler | .NET Fiddle";

        private const string NunitText = "NUnit";

        public AutomationTechTestLandingPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement RunButton { get { return this.Driver.FindElement(By.CssSelector("button#run-button.btn.btn-default")); } }

        public IWebElement SaveButton { get { return this.Driver.FindElement(By.CssSelector("button#save-button.btn.btn-default")); } }

        public IWebElement HelloWorldText { get { return this.Driver.FindElement(By.CssSelector("div.output-pane.pane>div#output")); } }

        public IWebElement FirstNameText { get { return this.Driver.FindElement(By.CssSelector("div.name-container>input")); } }


        public IWebElement NugetPackagesText { get { return this.Driver.FindElement(By.CssSelector("input.new-package.form-control.input-sm")); } }

        public IWebElement NunitPackageText { get { return this.Driver.FindElement(By.CssSelector("a#ui-id-11.ui-corner-all")); } }


        public IWebElement NunitPackageSelectedText { get { return this.Driver.FindElement(By.CssSelector("a#ui-id-1.ui-corner-all")); } }
        public IWebElement NPackageListSelected { get { return this.Driver.FindElement(By.CssSelector("ul.ui-menu.ui-widget.ui-widget-content.ui-corner-all>li:nth-child(1)")); } }

        public IWebElement NPackageNumberSelected { get { return this.Driver.FindElement(By.XPath("//*[@class='ui-menu-item']//a[@version-name='3.12.0.0']")); } }


        public IWebElement NPackageNameText { get { return this.Driver.FindElement(By.CssSelector("div.package-name")); } }

        public IWebElement AppLink { get { return this.Driver.FindElement(By.XPath("//*[@href='https://dotnetfiddle.net/']")); } }
        //h4#login-modal-label.modal-title  //*[@href='/GettingStarted/']  //*[@class='btn btn-default' and @href='/']
        public IWebElement BackGettingStartedButton { get { return this.Driver.FindElement(By.XPath("//*[@class='btn btn-default' and @href='/']")); } }
        public IWebElement GettingStartedButton { get { return this.Driver.FindElement(By.XPath("//*[@href='/GettingStarted/']")); } }
        public IWebElement OptionsLabel { get { return this.Driver.FindElement(By.XPath("//*[@class='text-center']//strong")); } }
        public IWebElement SignButton { get { return this.Driver.FindElement(By.CssSelector("button.btn.btn-default.btn-xs.btn-sidebar-toggle")); } }

        public IWebElement WindowLoginText { get { return this.Driver.FindElement(By.CssSelector("h4#login-modal-label.modal-title")); } }
        public bool IsNugetPackageDisplayed
        {
            get
            {
                Wait.Until(TimeSpan.FromSeconds(20), () => this.NPackageNameText.Displayed);
                var isDisplayed = this.NPackageNameText.Displayed;
                return isDisplayed;
            }
        }

        public void LoadPage()
        {
            this.Driver.Navigate().GoToUrl(AutomationProperties.DigitalUrl);
        }

        public void ClickRunButton()
        {
            Wait.Until(TimeSpan.FromSeconds(20), () => this.RunButton.Displayed);
            this.RunButton.Click();

        }

        public void ClickSaveButton()
        {
            Wait.Until(TimeSpan.FromSeconds(20), () => this.SaveButton.Displayed);
            this.RunButton.Click();

        }

        public string TextMessage
        {
            get
            {

                   Wait.Until(TimeSpan.FromSeconds(20), () => this.HelloWorldText.Displayed);
                   var txtMessage = this.HelloWorldText.Text;
                   return txtMessage;

            }
        }

        public string NugetPackageTextAdded
        {
            get
            {

                Wait.Until(TimeSpan.FromSeconds(20), () => this.NPackageNameText.Displayed);
                var txtMessage = this.NPackageNameText.Text;
                return txtMessage;

            }
        }

        public AutomationTechTestLandingPage WithFirstname(string fname)
        {
            Wait.Until(TimeSpan.FromSeconds(20), () => this.FirstNameText.Displayed);
            this.FirstNameText.EnterText(fname);
            return this;
        }

        public AutomationTechTestLandingPage WithNPackagename(string nugname)
        {
            this.NugetPackagesText.Click();
            Wait.Until(TimeSpan.FromSeconds(20), () => this.NugetPackagesText.Displayed);
            this.NugetPackagesText.EnterText(nugname);



              Wait.Until(TimeSpan.FromSeconds(20), () => this.NunitPackageSelectedText.Displayed);
            this.NunitPackageSelectedText.Hover(this.Driver);
            this.NunitPackageSelectedText.Click();


            Wait.Until(TimeSpan.FromSeconds(20), () => this.NPackageNumberSelected.Displayed);
           this.NPackageNumberSelected.Hover(this.Driver);
            this.NPackageNumberSelected.Click();
            return this;
        }

        public AutomationTechTestLandingPage WithNugetPackaes(string nPkgname)
        {
            Wait.Until(TimeSpan.FromSeconds(20), () => this.NugetPackagesText.Displayed);
            this.NugetPackagesText.EnterText(nPkgname);
            return this;
        }


       


    }
}

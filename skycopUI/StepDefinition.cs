using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;


namespace SkycopUI
{
    [Binding]
    public class StepDefinition
    {
        private PageObject _pageObject;
        public PageObject PageObject => _pageObject ?? (_pageObject = new PageObject());
        public static IWebDriver Driver;
        public class Browser 

        {
            public IWebDriver Chrome;

            public Browser()
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                Chrome = new ChromeDriver(options);
            }
        }

        public StepDefinition(Browser browser)
        {
            Driver = browser.Chrome;
            PageFactory.InitElements(Driver, PageObject);
        }

        [Given(@"I Open Skycop website")]
        public void GivenIOpenSkycopWebsite()
        {
            Driver.Url = "https://claim.skycop.com/?lang=en";
        }

        [When(@"I enter test airports")]
        public void WhenIEnterTestAirports()
        {
            Hooks.WaitIsDisplayed(PageObject.DeparturePort);
            PageObject.DeparturePort.SendKeys("Kaunas");
            Hooks.WaitIsDisplayed(PageObject.DepartureSelect, click: true);
            PageObject.ArrivalPort.SendKeys("Barcelona");
            PageObject.ArrivalSelect.Click();
        }

        [When(@"I fill in details")]
        public void WhenIFillInDetails()
        {
            ScenarioContext.Current.Pending();
        }

    }
}

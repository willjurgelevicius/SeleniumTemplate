using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;


namespace SeleniumTemplate
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

        [Given(@"I navigate to claims")]
        public void GivenINavigateToClaims()
        {
            Driver.Url = "https://claim.skycop.com";
        }

        [Then(@"I set Kaunas as departure airport")]
        public void ThenISetKaunasAsDepartureAirport()
        {
            Thread.Sleep(2000);
            var departureAirportField = Driver.FindElement(By.XPath("(//input[@class='Select-input'])[1]"));
            departureAirportField.SendKeys("Kaunas");
            Thread.Sleep(2000);
            var kaunasSelection = Driver.FindElement(By.XPath("//div[@title='Kaunas International Airport']"));
            kaunasSelection.Click();
        }

        [Then(@"I set London Gatwick as arrival airport")]
        public void ThenISetLondonGatwickAsArrivalAirport()
        {
            var arrivalAirportField = Driver.FindElement(By.XPath("(//input[@class='Select-input'])[2]"));
            arrivalAirportField.SendKeys("Gatwick");
            Thread.Sleep(3000);
            var gatwickSelection = Driver.FindElement(By.XPath("//div[@title='London Gatwick Airport']"));
            gatwickSelection.Click();
        }

        [Then(@"I select airlines")]
        public void ThenISelectAirlines()
        {
            var airlineField = Driver.FindElement(By.XPath("(//input[@class='Select-input'])[3]"));
            airlineField.SendKeys("Ryanair");
            Thread.Sleep(4000);
            var airlineSelection = Driver.FindElement(By.XPath("//div[@title='Ryanair']"));
            airlineSelection.Click();
        }

        [Then(@"I enter flight number")]
        public void ThenIEnterFlightNumber()
        {
            var flightNumberField = Driver.FindElement(By.XPath("//input[@name='failedFlightNumberDigits']"));
            flightNumberField.SendKeys("1234");
        }


    }
}
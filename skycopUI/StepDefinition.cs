using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
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

        [Given(@"I Open Skycop claim page")]
        public void GivenIOpenSkycopClaimPage()
        {
            Driver.Url = "https://claim.skycop.com/?lang=en";
        }

        [When(@"I enter test airports")]
        public void WhenIEnterTestAirports()
        {
            Hooks.WaitIsDisplayed(PageObject.DeparturePort);
            PageObject.DeparturePort.SendKeys("Kaunas");
            Hooks.WaitIsDisplayed(PageObject.DepartureSelect, false, true);
            PageObject.ArrivalPort.SendKeys("Barcelona");
            Hooks.WaitIsDisplayed(PageObject.ArrivalSelect, false, true);
            PageObject.AirlinesInput.SendKeys("Ryanair");
            Hooks.WaitIsDisplayed(PageObject.AirlinesSelect, false, true);
            Hooks.WaitIsDisplayed(PageObject.FlightNoInput);
            PageObject.FlightNoInput.SendKeys("1568");
            Hooks.WaitIsDisplayed(PageObject.FlightDateInput, click: true);
            Hooks.WaitIsDisplayed(PageObject.FlightDateToday, click: true);
            Hooks.WaitIsDisplayed(PageObject.FlightCancelled, click: true);
            Hooks.WaitIsDisplayed(PageObject.FlightMoreThan3,  false,true);
            Hooks.WaitIsDisplayed(PageObject.FlightLessThan14d,  false, true);
            Hooks.WaitIsDisplayed(PageObject.AirlineReasonInput,  false, true);
            Hooks.WaitIsDisplayed(PageObject.AirlineReasonSelect,  false, true);
            Hooks.WaitIsDisplayed(PageObject.ReferralInput,  false, true);
            Hooks.WaitIsDisplayed(PageObject.ReferralSelect,  false, true);
            Hooks.WaitIsDisplayed(PageObject.NextStep,  false, true);
        }

        [When(@"I fill in flight details")]
        public void WhenIFillInDetails()
        {
            Hooks.WaitIsDisplayed(PageObject.CommentInput);
            PageObject.CommentInput.SendKeys(Constants.Comment);
            PageObject.BookingNoInput.SendKeys(Constants.BookingNo);
            Hooks.WaitIsDisplayed(PageObject.NextStep, click: true);
        }

        [When(@"I fill in traveller details")]
        public void WhenIFillInTravellerDetails()
        {
            Random rand = new Random();
            Hooks.WaitIsDisplayed(PageObject.NameInput);
            PageObject.NameInput.SendKeys(Constants.FirstName);
            PageObject.SurnameInput.SendKeys(Constants.LastName);
            PageObject.BirthdateInput.Click();
            Hooks.WaitIsDisplayed(PageObject.BirthdateYearSelect, click: true);
            Hooks.WaitIsDisplayed(PageObject.BirthdateMonthSelect, click: true);
            Hooks.WaitIsDisplayed(PageObject.BirthdateDaySelect, click: true);
            Hooks.WaitIsDisplayed(PageObject.TravelingAloneInput, click: true);
            PageObject.CountryInput.SendKeys(Constants.Country);
            Hooks.WaitIsDisplayed(PageObject.CountrySelect, click: true);
            Hooks.WaitIsDisplayed(PageObject.LanguageInput, click: true);
            Hooks.WaitIsDisplayed(PageObject.LanguageSelect, click: true);
            PageObject.EmailInput.SendKeys(rand.Next(10000000).ToString() + "@gmail.com");
            PageObject.PhoneNoInput.SendKeys(Constants.PhoneNo);
            PageObject.AddressInput.SendKeys(Constants.Address);
            PageObject.CityInput.SendKeys(Constants.City);
            PageObject.PostcodeInput.SendKeys(Constants.Postcode);
            Hooks.WaitIsDisplayed(PageObject.NextStep, click: true);
        }

        [When(@"I sign aggreement")]
        public void WhenISignAggreement()
        {
            Hooks.WaitIsDisplayed(PageObject.SignatureCanvas);
            Actions builder = new Actions(Driver);
            IAction drawAction = builder.MoveToElement(PageObject.SignatureCanvas, 10, 10)
                .ClickAndHold()
                .MoveByOffset(50, 50)
                .Release()
                .Build();
            drawAction.Perform();
            Thread.Sleep(500);
            IAction drawAction1 = builder.MoveToElement(PageObject.SignatureCanvas, 30, 15)
                .ClickAndHold()
                .MoveByOffset(50, 60)
                .Release()
                .Build();
            drawAction1.Perform();
            Thread.Sleep(500);
            IAction drawAction2 = builder.MoveToElement(PageObject.SignatureCanvas, 80, 20)
                .ClickAndHold()
                .MoveByOffset(50, 70)
                .Release()
                .Build();
            drawAction2.Perform();
            Hooks.WaitIsDisplayed(PageObject.CompleteClaimButton, click: true);
        }

        [Then(@"I see that claim is completed")]
        public void ThenISeeThatClaimIsCompleted()
        {
            Hooks.WaitIsDisplayed(PageObject.ClaimSuccess);
        }

    }
}

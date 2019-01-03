
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SkycopUI
{
    public class PageObject
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='menu-item-10281']/a[contains(@text,'')]")]
        public IWebElement NavigateClaimForm;

        [FindsBy(How = How.XPath, Using = "//input[@class='Select-input']")]
        public IWebElement DeparturePort;

        [FindsBy(How = How.XPath, Using = "//div[@title='Kaunas International Airport']")]
        public IWebElement DepartureSelect;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[2]")]
        public IWebElement ArrivalPort;

        [FindsBy(How = How.XPath, Using = "//div[@title='Barcelona International Airport']")]
        public IWebElement ArrivalSelect;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[3]")]
        public IWebElement AirlinesInput;

        [FindsBy(How = How.XPath, Using = "//div[@title='Ryanair']")]
        public IWebElement AirlinesSelect;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='1234']")]
        public IWebElement FlightNoInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='failedFlightDate']")]
        public IWebElement FlightDateInput;

        [FindsBy(How = How.XPath, Using = "//td[@class='rdtDay rdtToday']")]
        public IWebElement FlightDateToday;

        [FindsBy(How = How.XPath, Using = "//input[@value='can']/..//span")]
        public IWebElement FlightCancelled;

        [FindsBy(How = How.XPath, Using = "//input[@value='dg3']/..//span")]
        public IWebElement FlightMoreThan3;

        [FindsBy(How = How.XPath, Using = "//input[@value='l14']/..//span")]
        public IWebElement FlightLessThan14d;

        [FindsBy(How = How.XPath, Using = "(//div[@class='Select-control'])[5]")]
        public IWebElement AirlineReasonInput;

        [FindsBy(How = How.XPath, Using = "//div[@id='react-select-6--option-0']")]
        public IWebElement AirlineReasonSelect;

        [FindsBy(How = How.XPath, Using = "(//div[@class='Select-control'])[6]")]
        public IWebElement ReferralInput;

        [FindsBy(How = How.XPath, Using = "//div[@id='react-select-7--option-0']")]
        public IWebElement ReferralSelect;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement NextStep;

        [FindsBy(How = How.XPath, Using = "//textarea[@name='comments']")]
        public IWebElement CommentInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='bookingNumber']")]
        public IWebElement BookingNoInput;

        [FindsBy(How = How.CssSelector, Using = "#time_from")]
        public IWebElement StartDateField;

        [FindsBy(How = How.CssSelector, Using = "#hour_from")]
        public IWebElement StartHourField;

        [FindsBy(How = How.CssSelector, Using = "#time_to")]
        public IWebElement EndDateField;

        [FindsBy(How = How.CssSelector, Using = "#hour_to")]
        public IWebElement EndHourField;

        [FindsBy(How = How.XPath, Using = "//a[@class='cookieConsentOK']")]
        public IWebElement CookieConsentAcceptField;

        [FindsBy(How = How.XPath, Using = "//div[@class='filter-1']//div[contains(@class, 'order-button') and not(contains(@class, 'order-button-mob'))]//button[@name='submit']")]
        public IWebElement ContinueOrderButton;

        [FindsBy(How = How.XPath, Using = "//input[@id='nr' and @type='text']")]
        public IWebElement CarNoField;

        [FindsBy(How = How.XPath, Using = "//div[@id='step_2']//input[@name='firstname' and @type='text']")]
        public IWebElement FirstNameField;

        [FindsBy(How = How.XPath, Using = "//div[@id='step_2']//input[@name='lastname' and @type='text']")]
        public IWebElement LastNameField;

        [FindsBy(How = How.XPath, Using = "//div[@id='step_2']//input[@name='phone_number' and @type='text']")]
        public IWebElement PhoneNoField;

        [FindsBy(How = How.XPath, Using = "//div[@id='step_2']//input[@name='email' and @type='text']")]
        public IWebElement EmailField;

        [FindsBy(How = How.XPath, Using = "//div[@id='step_2']//label[@for='newsletter']")]
        public IWebElement NewsletterCheckbox;

        [FindsBy(How = How.XPath, Using = "//div[@id='step_2']//label[@for='name']")]
        public IWebElement ReceiptCheckbox;

        [FindsBy(How = How.XPath, Using = "//div[@id='step_2']//input[@name='title' and @type='text']")]
        public IWebElement CompanyTitleField;

        [FindsBy(How = How.XPath, Using = "//div[@id='step_2']//input[@name='code' and @type='text']")]
        public IWebElement CompanyCodeField;

        [FindsBy(How = How.XPath, Using = "//div[@id='step_2']//input[@name='address' and @type='text']")]
        public IWebElement CompanyAddressField;

        [FindsBy(How = How.XPath, Using = "//div[@id='step_2']//input[@name='vat_code' and @type='text']")]
        public IWebElement CompanyVatCodeField;

        [FindsBy(How = How.XPath, Using = "//div[@id='step_2']//label[@for='rules']")]
        public IWebElement RulesCheckbox;

        [FindsBy(How = How.XPath, Using = "//button[@id='accept-button']")]
        public IWebElement AcceptTermsButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='message red']")]
        public IWebElement GeneralErrorMessage;

        [FindsBy(How = How.XPath, Using = "//input[@name='buy_now_submit']")]
        public IWebElement SubmitParkingOrder;

        [FindsBy(How = How.XPath, Using = "//div[@id='place_0']//td[@class='coll-4']")]
        public IList<IWebElement> ParkingOptionPrices;

        [FindsBy(How = How.XPath, Using = "//table[@data-zones]")]
        public IList<IWebElement> ExtraBookingOptions;

        [FindsBy(How = How.XPath, Using = "//span[@id='step_2_time_from']")]
        public IWebElement OrderReviewFromDate;

        [FindsBy(How = How.XPath, Using = "//span[@id='step_2_time_to']")]
        public IWebElement OrderReviewToDate;
    }
}

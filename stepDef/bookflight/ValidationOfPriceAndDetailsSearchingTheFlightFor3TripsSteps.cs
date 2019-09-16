using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace Test.stepDef.bookflight
{
    [Binding]
    public class ValidationOfPriceAndDetailsSearchingTheFlightFor3TripsSteps
    {
        public IWebDriver Driver;
        public WebDriverWait wait;
        public IWebElement element;
        [Given(@"go to expedia website")]
        public void GivenGoToExpediaWebsite()
        {
            Driver = new ChromeDriver(@"C:\Users\deepanshusharma\Desktop\chromedriver_win32");
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.expedia.com/");
        }
        
        [Given(@"select multiflight option")]
        public void GivenSelectMultiflightOption()
        {
            Driver.FindElement(By.Id("tab-flight-tab-hp")).Click();
            Driver.FindElement(By.Id("flight-type-multi-dest-label-hp-flight")).Click();
        }
        
        [When(@"I search the flight between airports (.*), (.*), (.*) on dates (.*), (.*), (.*) for (.*) Adults")]
        public void WhenISearchTheFlightBetweenAirportsMLALONROMOnDatesForAdults(string first, string second, string third, string date1, string date2, string date3, int N)
        {
            wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='flight-origin-hp-flight']")));
            Driver.FindElement(By.XPath("//*[@id='flight-origin-hp-flight']")).Click();
            Driver.FindElement(By.XPath("//*[@id='flight-origin-hp-flight']")).SendKeys(first);

            Driver.FindElement(By.XPath("//*[@id='flight-destination-hp-flight']")).Click();
            Driver.FindElement(By.XPath("//*[@id='flight-destination-hp-flight']")).SendKeys(second);

            Driver.FindElement(By.Id("flight-departing-single-hp-flight")).SendKeys(date1);
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//*[@id='traveler-selector-hp-flight']/div/ul/li/button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//*[@id='traveler-selector-hp-flight']/div/ul/li/div/div/div/div[1]/div[4]")).Click();
            Driver.FindElement(By.XPath("//*[@id='traveler-selector-hp-flight']/div/ul/li/div/div/div/div[1]/div[4]")).Click();
            Driver.FindElement(By.XPath("//*[@id='traveler-selector-hp-flight']/div/ul/li/div/div/div/div[1]/div[4]")).Click();
            Driver.FindElement(By.XPath("//*[@id='traveler-selector-hp-flight']/div/ul/li/button")).Click();
            Driver.FindElement(By.XPath("//*[@id='flight-2-origin-hp-flight']")).Click();
            Driver.FindElement(By.XPath("//*[@id='flight-2-origin-hp-flight']")).SendKeys(second);

            Driver.FindElement(By.XPath("//*[@id='flight-2-destination-hp-flight']")).Click();
            Driver.FindElement(By.XPath("//*[@id='flight-2-destination-hp-flight']")).SendKeys(third);


            Driver.FindElement(By.XPath("//*[@id='flight-2-departing-hp-flight']")).SendKeys(date2);
            Driver.FindElement(By.XPath("//*[@id='add-flight-leg-hp-flight']")).Click();
            Driver.FindElement(By.XPath("//*[@id='flight-3-destination-hp-flight']")).SendKeys(first);
            Driver.FindElement(By.XPath("//*[@id='flight-3-departing-hp-flight']")).SendKeys(date3);
        }
        
        [When(@"click on search flight")]
        public void WhenClickOnSearchFlight()
        {
            Driver.FindElement(By.XPath("//div[@class='cols-nested ab25184-submit']//button[@class='btn-primary btn-action gcw-submit']")).Click();
        }
        //working till here
        [Then(@"The Total price should be equal to (.*) multiplied by price of single person")]
        public void ThenTheTotalPriceShouldBeEqualToMultipliedByPriceOfSinglePerson(int p0)
        {
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath("(//button[@class='btn-secondary btn-action t-select-btn'])[1]")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("(//button[@class='btn-secondary btn-action t-select-btn'])[1]")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("(//button[@class='btn-secondary btn-action t-select-btn'])[1]")).Click();
        }
        
        [Then(@"Trip details as FirstTrip from (.*) to (.*) SecondTrip from (.*) to (.*) ThirdTrip from (.*) to (.*)")]
        public void ThenTripDetailsAsFirstTripFromMaltaIntl_MLAToHeathrowLHRSecondTripFromHeathrowLHRToFiumicino_LeonardoDaVinciIntl_FCOThirdTripFromFiumicino_LeonardoDaVinciIntl_FCOToMaltaIntl_MLA(string dept1, string arr1, string dept2, string arr2, string dept3, string arr3)
        {
            Thread.Sleep(6000);
            IList<string> tabs = new List<string>(Driver.WindowHandles);
            Driver.SwitchTo().Window(tabs[1]);
            Thread.Sleep(1000);
            // Driver.FindElement(By.XPath("//*[@id='bookButton']")).Click();

            string goOne = Driver.FindElement(By.XPath("/html/body/main/div/div[1]/section[2]/div[2]/div[1]/div/div/div[1]/div[2]/div[2]")).GetAttribute("innerHTML");
            string toOne = Driver.FindElement(By.XPath("/html/body/main/div/div[1]/section[2]/div[2]/div[1]/div/div/div[1]/div[2]/div[4]")).GetAttribute("innerHTML");

            string goTwo = Driver.FindElement(By.XPath("/html/body/main/div/div[1]/section[2]/div[2]/div[2]/div/div/div[1]/div[2]/div[2]")).GetAttribute("innerHTML");
            string toTwo = Driver.FindElement(By.XPath("/html/body/main/div/div[1]/section[2]/div[2]/div[2]/div/div/div[1]/div[2]/div[4]")).GetAttribute("innerHTML");

            string goThree = Driver.FindElement(By.XPath("/html/body/main/div/div[1]/section[2]/div[2]/div[3]/div/div/div[1]/div[2]/div[2]")).GetAttribute("innerHTML");
            string toThree = Driver.FindElement(By.XPath("/html/body/main/div/div[1]/section[2]/div[2]/div[3]/div/div/div[1]/div[2]/div[4]")).GetAttribute("innerHTML");

            /*string firstPersonCost = Driver.FindElement(By.XPath("//*[@id='totalPriceForPassenger1-desktopView']")).GetAttribute("innerHTML");
            string totalCost = Driver.FindElement(By.XPath("/html/body/main/div/div[2]/section[1]/div/div[2]/div/div[1]/span[2]")).GetAttribute("innerHTML");
            double perPersontimesFour = 4*Convert.ToDouble(firstPersonCost);*/

            Assert.AreEqual(goOne,dept1);
            Assert.AreEqual(goTwo, dept2);
            Assert.AreEqual(goThree, dept3);
            Assert.AreEqual(toOne, arr1);
            Assert.AreEqual(toTwo, arr2);
            Assert.AreEqual(toThree, arr3);

            String value1person = Driver.FindElement(By.Id("totalPriceForPassenger1-mobileTabletView")).GetAttribute("innerHTML");
            String[] Price = value1person.Split('$');
            double final1Val = double.Parse(Price[1]);

            string totalCost = Driver.FindElement(By.XPath("/html/body/main/div/div[1]/section[1]/div/div[2]/div/div[1]/span[2]")).GetAttribute("innerHTML");
            String[] PriceTot = totalCost.Split('$');
            double final1totVal = double.Parse(Price[1]);
            double finvalue = final1Val * 4;
            Assert.AreEqual(final1Val, final1totVal);
        }

        [Then(@"Close all Windows of Expedia")]
        public void ThenCloseAllWindowsOfExpedia()
        {
            //Driver.Quit();
        }
    }
}

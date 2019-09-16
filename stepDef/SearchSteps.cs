using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using System.ComponentModel.DataAnnotations;
using NUnit.Framework;

namespace Test.stepDef
{
    [Binding]
    public class SearchSteps
    {
        public IWebDriver driver;
        string expected_outcome = "";
        [Given(@"Launch Chrome")]
        public void GivenLaunchChrome()
        {
            driver = new ChromeDriver(@"C:\Users\deepanshusharma\Desktop\chromedriver_win32");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            driver.Manage().Window.Maximize();
        }
        [Given(@"Navigate to login Page")]
        public void GivenNavigateToLoginPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        [Given(@"Click on SignIn button")]
        public void GivenClickOnSignInButton()
        {
            driver.FindElement(By.LinkText("Sign in")).Click();
        }
        [Then(@"enter (.*) and (.*)")]
        public void ThenEnterAnd(string email, string pass)
        {
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("passwd")).SendKeys(pass);
            if(email == "" && pass == "")
            {
                expected_outcome = "An email address required.";
            }
            else if(pass == "")
            {
                expected_outcome = "Password is required.";
            }
            else if (email == "")
            {
                expected_outcome = "An email address required.";
            }
            else
            {
                expected_outcome = "Authentication failed.";
            }
        }
        [Then(@"Click on Login Button")]
        public void ThenClickOnLoginButton()
        {
            driver.FindElement(By.Id("SubmitLogin")).Click();
        }
        [Then(@"error will be visible and browser should close")]
        public void ThenErrorWillBeVisibleAndBrowserShouldClose()
        {
            IWebElement element = driver.FindElement(By.XPath(" //*[@id='center_column']/div[1]/ol/li"));
            string actualoutput = element.GetAttribute("innerHTML");
            Assert.AreEqual(expected_outcome, actualoutput);
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}

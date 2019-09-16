using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Class1
    {
        public void Search_Test()
        {
            //Launch browser
            IWebDriver driver = new ChromeDriver(@"C:\Users\deepanshusharma\Desktop\chromedriver_win32");


            //navigate to url
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            driver.Navigate().GoToUrl("https://www.codeproject.com");

            //click on search
            driver.FindElement(By.XPath("//*[@id='ctl00_ContentPane']/div[1]/div/table[1]/tbody/tr/td[3]/a/img")).Click();

            //enter testing
            driver.FindElement(By.Id("ctl00_MC_Go")).Click();
            driver.Quit();
        }
    }
}

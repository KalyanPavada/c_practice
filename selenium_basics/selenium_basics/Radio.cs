using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_basics
{
    internal class Radio
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/radio-button";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/ul[1]/li[3]")).Click();
            driver.FindElement(By.XPath("//label[contains(text(),'Yes')]")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//label[contains(text(),'Impressive')]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.Close();



        }
    }
}

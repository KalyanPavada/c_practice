using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;


namespace selenium_basics
{
    internal class Check
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/text-box";
            driver.FindElement(By.XPath("//span[contains(text(),'Check Box')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/ol[1]/li[1]/span[1]/button[1]/*[1]")).Click();
            driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/ol[1]/li[1]/ol[1]/li[1]/span[1]/button[1]/*[1]")).Click();
            driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/ol[1]/li[1]/ol[1]/li[2]/span[1]/button[1]/*[1]")).Click();
            driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/ol[1]/li[1]/ol[1]/li[1]/span[1]/label[1]/span[1]/*[1]")).Click();
            driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/ol[1]/li[1]/ol[1]/li[2]/ol[1]/li[1]/span[1]/label[1]/span[1]/*[1]")).Click();

        }
    }
}

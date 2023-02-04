using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_basics
{
    internal class text_enter
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/text-box";
            driver.FindElement(By.Id("userName")).SendKeys("Kalyan");
            driver.FindElement(By.Id("userEmail")).SendKeys("abcd@gmail.com");
            driver.FindElement(By.XPath("//textarea[@id='currentAddress']")).SendKeys("abc colony,ameerpet");
            IWebElement pa = driver.FindElement(By.Id("permanentAddress"));
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("arguments[0].value='vizianagaram,vzm'",pa);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.Id("submit")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(30));
        }
    }
}

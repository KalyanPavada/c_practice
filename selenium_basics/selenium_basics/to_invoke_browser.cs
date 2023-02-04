using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_basics
{
    internal class to_invoke_browser
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Url = "https://www.bestdotnettraining.com/testingsuite";
            driver.Navigate().GoToUrl("https://www.bestdotnettraining.com/testingsuite");


        }
    }
}

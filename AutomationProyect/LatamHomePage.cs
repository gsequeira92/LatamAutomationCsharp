using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProyect
{
    class LatamHomePage
    {
        IWebDriver driver;
        By originCity = By.CssSelector("#compra-select-origin");
        By destinationCity = By.CssSelector("#compra-select-destination");

        public LatamHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeOriginCity(String origin)
        {
            driver.FindElement(originCity).SendKeys(origin);
        }

        public void TypeDestinationCity(String destination)
        {
            driver.FindElement(destinationCity).SendKeys(destination);
        }
    }
}

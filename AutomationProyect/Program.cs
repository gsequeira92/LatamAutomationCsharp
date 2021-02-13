using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationProyect
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Url = "https://www.aerolineas.com.ar/";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.ClassName("nav-search-input")).SendKeys("Espejo de pared" + Keys.Enter);
            driver.FindElement(By.XPath("//div/div[1]/aside/section[2]/dl[2]/dd/a/span[1])")).Click();
            driver.FindElement(By.ClassName("ui-search-list-desktop")).Click();

            By username = By.Id("testingThis");
         
            Object[] publicaciones = new Object[10];

            for (int i= 0; i< publicaciones.Length; i++)
            {
                publicaciones[i] = driver.FindElement(By.XPath("//section[@class='ui-search-results']"));

            }

            for (int i = 0; i < publicaciones.Length; i++)
            {
                Console.WriteLine(publicaciones[i]);

            }

            driver.Quit();

        }

    }
}

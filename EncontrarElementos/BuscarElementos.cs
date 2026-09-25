using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace EncontrarElementos
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void encontrarElementos()

        {
            string rutaHtML = "file:///C:/Users/Usuario/Documents/Webs/index.html";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(rutaHtML);
            IWebElement nombre = driver.FindElement(By.Id("nombre"));
            nombre.FindElement(By.Id("nombre")).SendKeys("Nicolas");
        }
    }
}
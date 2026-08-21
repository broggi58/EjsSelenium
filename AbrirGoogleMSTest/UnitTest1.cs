using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbrirGoogleMSTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void BuscarGoogle()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://google.com");

            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Hola");
            element.Submit();

            driver.Quit();

        }
    }
}

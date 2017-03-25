namespace SeleniumTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;
    using OpenQA.Selenium.Support.UI;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TryLogin()
        {
            // Arrange
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            
            // Act
            driver.Navigate().GoToUrl("http://www.abv.bg/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("username")).SendKeys("qasoftunirandom");
            driver.FindElement(By.Id("password")).SendKeys("QAsoftuni");
            wait.Until(ExpectedConditions.ElementExists(By.Id("loginBut")));
            driver.FindElement(By.Id("loginBut")).Click();

            wait.Until(ExpectedConditions.ElementExists(By.ClassName("userName")));
            string expectedUsername = "Kichka Bodurova";
            string actualUsername = driver.FindElement(By.ClassName("userName")).Text;

            // Assert
            Assert.AreEqual(expectedUsername, actualUsername);
            driver.Quit();
        }
    }
}

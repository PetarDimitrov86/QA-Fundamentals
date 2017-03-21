namespace UnitTestProject2
{
    using System.Threading;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    [TestClass]
    public class AbvSignInTest
    {
        [TestMethod]
        public void TryLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.abv.bg/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("username")).SendKeys("qasoftunirandom");
            driver.FindElement(By.Id("password")).SendKeys("QAsoftuni");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("loginBut")).Click();
            Thread.Sleep(3000);
            string expectedUsername = "Kichka Bodurova";
            string actualUsername = driver.FindElement(By.ClassName("userName")).Text;

            Assert.AreEqual(expectedUsername, actualUsername);
            driver.Quit();
        }
    }
}

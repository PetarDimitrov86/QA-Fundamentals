namespace SeleniumTest
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;
    using System.Threading;

    class AbvLoginTest
    {
        static void Main()
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

            if (expectedUsername == actualUsername)
            {
                Console.WriteLine("Actual username matches expected username");
            }
            else
            {
                Console.WriteLine("Usernames do not match");
            }
            driver.Quit();
        }
    }
}
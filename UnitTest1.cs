using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.InteropServices;

namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();



        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("https://www.bstackdemo.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.Id("signin")).Click();

            Thread.Sleep(1000);
            driver.FindElement(By.Id("react-select-2-input")).SendKeys("demouser");
            driver.FindElement(By.Id("react-select-2-input")).SendKeys(Keys.Tab);

            Thread.Sleep(1000);
            driver.FindElement(By.Id("react-select-3-input")).SendKeys("testingisfun99");
            driver.FindElement(By.Id("react-select-3-input")).SendKeys(Keys.Tab);

            Thread.Sleep(1000);
            driver.FindElement(By.Id("login-btn")).Click();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()='Apple']")).Click();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//option[@value='lowestprice']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[text()='Add to cart']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".buy-btn")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Id("firstNameInput")).SendKeys("Test First Name");
            driver.FindElement(By.Id("lastNameInput")).SendKeys("Test Last Name");
            driver.FindElement(By.Id("addressLine1Input")).SendKeys("Test Address");
            driver.FindElement(By.Id("provinceInput")).SendKeys("Test State/Province");
            driver.FindElement(By.Id("postCodeInput")).SendKeys("Test Post Code");

            Thread.Sleep(1000);
            driver.FindElement(By.Id("checkout-shipping-continue")).Click();

            Thread.Sleep(1000);
            driver.FindElement(By.Id("downloadpdf")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='Continue Shopping »']")).Click();

            Thread.Sleep(1000);
            driver.FindElement(By.Id("downloadpdf")).Click();

        }

        [TearDown]
        public void Cleanup() 
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }


    }
}
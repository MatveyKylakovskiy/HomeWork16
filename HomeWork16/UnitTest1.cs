
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HomeWork16
{
    public class Tests
    {
        IWebDriver driver;
        WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            var chromeOption = new ChromeOptions();
            chromeOption.AddArguments("start-maximise");
            driver = new ChromeDriver(chromeOption);
            driver.Navigate().GoToUrl("https://www.desmos.com/scientific?lang=ru");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        }

        [Test]
        public void Test1()
        {
           
            var one = GetElementByXPass(1);
            var two = GetElementByXPass(2);
            one.Click();
            two.Click();

            
            
            one.Click();
            two.Click();

            //Thread.Sleep(5000);


            Assert.Equals(one.Text,"1");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }


        public IWebElement GetElementByXPass(int number) => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//*[@aria-label='{number}']")));
        

    }
}
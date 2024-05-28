using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HomeWork18.Factories
{
    public class Driver
    {
        private static IWebDriver? _driver;
        private static WebDriverWait _wait;

        public static WebDriverWait GetWait() => _wait ??= new(GetDriver(), TimeSpan.FromSeconds(100));
        public static void QuitDriver() => _driver?.Quit();
        public static IWebDriver GetDriver() => _driver ??= SetupDriver();
/*        {
            if (_driver == null)
            {
                SetupDriver();
            }
            return _driver;
        }*/

        private static IWebDriver SetupDriver() => new ChromeDriver();

        private static ChromeOptions GetOptions()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return options;
        }
     
       
    }
}

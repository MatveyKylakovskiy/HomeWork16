using HomeWork18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork18.Pages
{
    internal class CheckBox
    {
        public void OpenPage()
        {
                try
                {
                    Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }

        private IWebElement checkBox1 = Driver.GetWait().Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"checkboxes\"]//input[1]")));
        private IWebElement checkBox2 = Driver.GetWait().Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"checkboxes\"]//input[2]")));

        public void ClickBox()
        {
            checkBox1.Click();
            checkBox2.Click();
        }
    }
}

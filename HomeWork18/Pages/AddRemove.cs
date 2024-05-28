
using HomeWork18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace HomeWork18.Pages
{
    internal class AddRemove
    {
        
        private  IWebElement addElement = Driver.GetWait().Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Add Element']")));
        private  IWebElement deleteElement = Driver.GetWait().Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Delete']")));

   
        public  void AddElement() => addElement.Click();
       public  void DeleteElement() => deleteElement.Click();

       public  bool IsElementVisible() => deleteElement.Displayed;

       public  bool IsElementNotVisible() => deleteElement.Displayed;

        public void OpenURL()
        {
            try
            {
                Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

using HomeWork18.Factories;
using HomeWork18.Pages;

namespace HomeWork18
{
    public class Tests
    {
        

        [SetUp]
        public void Setup()
        {

            // Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");
        }



        [Test]
        public void Test1()
        {
            AddRemove addPage = new();
            addPage.AddElement();
            var vis = addPage.IsElementVisible();
            Assert.IsTrue(vis);
        }

        [Test]
        public void Test2()
        {
            CheckBox check = new();
            //check.OpenPage();
            check.ClickBox();

            Thread.Sleep(4000);
        }

        [TearDown]

        public void TearDown() => Driver.QuitDriver();
    }
}
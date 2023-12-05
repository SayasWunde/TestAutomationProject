using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;
namespace WebTestingProject.Scenarios
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class SpecialElementsPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [OneTimeSetUp] /*One time set up -- Exuted one time befor all the test below it */
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            Menu menu = new Menu(Driver);
            menu.SpecialElements.Click();
        }
        [Test]
        public void AlertBoxPostAndTitleVisibilityCheckInSpecialElementPage()
        {
            SpecialElements spElement = new SpecialElements(Driver);
            /*AlertBox post check*/
            Assert.That(spElement.Title.Text, Is.EqualTo("Special Elements"));
        }
        [Test]
        public void TextInputFieldPostVisibilityCheckInSpecialElementPage()
        {
            SpecialElements spElement = new SpecialElements(Driver);
            /* Text Input Field check*/
            Assert.That(spElement.TextInputField_Post.Text, Is.EqualTo(Config.PostsName.TestInputFieldPost));
        }
        [Test]
        public void CheckButtonTestPostVisibilityCheckInSpecialElementPage()
        {
            SpecialElements spElement = new SpecialElements(Driver);
            /* Check button test check*/
            Assert.That(spElement.CheckButtonTest_Post.Text, Is.EqualTo(Config.PostsName.CheckButtonTestPost));
        }
        [Test]
        public void RadioButtonTestPostVisibilityCheckInSpecialElementPage()
        {
            SpecialElements spElement = new SpecialElements(Driver);
            /* Radio button test check */
            Assert.That(spElement.RadioButtonTest_Post.Text, Is.EqualTo(Config.PostsName.RadioButtonTestPost));
        }
        [Test]
        public void DropDwonMenuTestPostVisibilityCheckInSpecialElementPage()
        {
            SpecialElements spElement = new SpecialElements(Driver);
            /* Drop down menu Test */
            Assert.That(spElement.DropDwonMenuTest_Post.Text, Is.EqualTo(Config.PostsName.DropdownmenuTestPost));
        }
        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}

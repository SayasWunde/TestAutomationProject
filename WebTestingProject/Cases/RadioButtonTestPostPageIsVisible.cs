using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class RadioButtonTestPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.RadioButtonTestPostThroughTheMenu(Driver);
        }
        [Test]
        public void RadioButtonTestPostPageVisibilityCheck()
        {
            Radio_Button_Test_Post radioButtonTest = new Radio_Button_Test_Post(Driver);
            Assert.That(radioButtonTest.Title.Text, Is.EqualTo(Config.PostsName.RadioButtonTestPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }


    }
}

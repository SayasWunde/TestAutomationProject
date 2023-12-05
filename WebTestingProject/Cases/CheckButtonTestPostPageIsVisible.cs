using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class CheckButtonTestPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.CheckButtonTestPostThroughTheMenu(Driver);
        }
        [Test]
        public void CheckButtonTestPostPageVisibilityCheck()
        {
            Check_Button_Test_Post checkButtonTest = new Check_Button_Test_Post(Driver);
            Assert.That(checkButtonTest.Title.Text, Is.EqualTo(Config.PostsName.CheckButtonTestPost));
        } 
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }



    }
}

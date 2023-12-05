using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class AlertBoxPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }

        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.AlertBoxPostThroughTheMenu(Driver);
        }
        [Test]
        public void AlertBoxPostPageVisibilityCheck()
        {
            AlertBoxPost alertBoxPost = new AlertBoxPost(Driver);
            Assert.That(alertBoxPost.Title.Text, Is.EqualTo(Config.PostsName.AlertBoxPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }






    }
}

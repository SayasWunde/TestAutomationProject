using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class IDPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.IDPostThroughTheMenu(Driver);
        }
        [Test]
        public void IDPostPageVisibilityCheck()
        {
            IDPost idpost = new IDPost(Driver);
            Assert.That(idpost.Title.Text, Is.EqualTo(Config.PostsName.IDPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}

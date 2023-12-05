using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    /*[Parallelizable] /*Will make the test run parallele*/
    [Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class CSSPathPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.CSSPathPostThroughTheMenu(Driver);
        }
        [Test]
        public void CSSPathPostPageVisibilityCheck()
        {
            CSSPathPost cSSPathPost = new CSSPathPost(Driver);
            Assert.That(cSSPathPost.Title.Text, Is.EqualTo(Config.PostsName.CSSPathPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}

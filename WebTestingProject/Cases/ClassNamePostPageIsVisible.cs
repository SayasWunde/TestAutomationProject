using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class ClassNamePostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.ClassNamePostThroughTheMenu(Driver);
        }
        [Test]
        public void CSSPathPostPageVisibilityCheck()
        {
            ClassNamePost classNamePost = new ClassNamePost(Driver);
            Assert.That(classNamePost.Title.Text, Is.EqualTo(Config.PostsName.ClassNamePost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }


    }
}

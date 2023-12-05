using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class XPathPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.XPathPostThroughTheMenu(Driver);
        }
        [Test]
        public void XPathPostPageVisibilityCheck()
        {
            XpathPost xpathPost = new XpathPost(Driver);
            Assert.That(xpathPost.Title.Text, Is.EqualTo(Config.PostsName.XPathPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}

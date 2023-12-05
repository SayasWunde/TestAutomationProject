using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;
using static WebTestingProject.Config.alertMessages;


namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class NamePostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.NamePostThroughTheMenu(Driver);
        }
        [Test]
        public void NamePostPageVisibilityCheck()
        {
            NamePost namePost = new NamePost(Driver);
            Assert.That(namePost.Title.Text, Is.EqualTo(Config.PostsName.NamePost));

        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }




    }
}

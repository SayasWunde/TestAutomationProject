using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;


namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class RightSideBarIsVisible
    {
        public IWebDriver Driver { get; set; }

        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();

        }
        [Test]
        public void RightSideBarVisibilityCheck()
        {
            RightSideBar rsbar = new RightSideBar(Driver);
            Assert.That(rsbar.RecentPosts_Title.Text
                , Is.EqualTo("RECENT POSTS"));
            Assert.That(rsbar.Categories_Title.Text, Is.EqualTo("CATEGORIES"));
            Assert.That(rsbar.Meta_Title.Text, Is.EqualTo("META"));
        }

        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}

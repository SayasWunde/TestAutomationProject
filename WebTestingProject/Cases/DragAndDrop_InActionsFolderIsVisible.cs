using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class DragAndDrop_InActionsFolderIsVisible
    {
        public IWebDriver Driver { get; set; }

        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            RightSideBar rsideb = new RightSideBar(Driver);
            rsideb.RecentPosts_DragAndDrop.Click();
        }
        [Test]
        public void AboutPageVisibilityCheck()
        {
            DragAndDrop_In_Action_Folder dragAndDrop = new DragAndDrop_In_Action_Folder(Driver);
            Assert.That(dragAndDrop.Title.Text, Is.EqualTo(Config.PostsName.DragAndDrop));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }



    }
}

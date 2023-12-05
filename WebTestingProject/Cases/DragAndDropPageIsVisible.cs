using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class DragAndDropPageIsVisible
    {

        public IWebDriver Driver { get; set; }

        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            RightSideBar rsideb = new RightSideBar(Driver);
            DragAndDrop_In_Action_Folder drag = new DragAndDrop_In_Action_Folder(Driver);
            rsideb.RecentPosts_DragAndDrop.Click();
            drag.LinkToDraganddropPage.Click();
        }
        [Test]
        public void DragAndDropPageVisibilityCheck()
        {
            DragAndDrop_Page dragAndDrop = new DragAndDrop_Page(Driver);
            Assert.That(dragAndDrop.Title.Text, Is.EqualTo(Config.PostsName.DragAnddropPageTitle));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}

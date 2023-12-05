using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class DropDownMenuTestPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.DropDownMenuTestPostThroughTheMenu(Driver);
        }
        [Test]
        public void DropDownMenuTestPostPageVisibilityCheck()
        {
            Drop_Down_Menu_Test_Post DDMenuTest = new Drop_Down_Menu_Test_Post(Driver);
            Assert.That(DDMenuTest.Title.Text, Is.EqualTo(Config.PostsName.DropdownmenuTestPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }


    }
}

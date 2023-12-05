using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;


namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class ItemInCategoryDropDownMenuPostPageIsVisible
    {

        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.ItemInCategoryDropDownMenuPostThroughTheMenu(Driver);
        }
        [Test]
        public void ItemInCategoryDropDownMenuPostPageVisibilityCheck()
        {
            Item_In_Category_Drop_Down_Menu_Post iicddmp = new Item_In_Category_Drop_Down_Menu_Post(Driver);
            Assert.That(iicddmp.Title.Text, Is.EqualTo(Config.PostsName.ItemsinCategoryDropDownMenuPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }





    }
}

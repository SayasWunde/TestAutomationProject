using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Scenarios
{
    [Parallelizable]// Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class Page_1_Todor_Vachev_Link_IsVisible
    {
        public IWebDriver Driver { get; set; }
        [OneTimeSetUp] /*One time set up -- Exuted one time befor all the test below it */
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.Page_1_Todor_Vachev_Link_ThroughNamePost(Driver);
        }
        [Test]
        public void TitleVisibilityCheck()
        {
            Page_1_Todor_Vachev_Link P1todo = new Page_1_Todor_Vachev_Link(Driver);
            /*Title  */
            Assert.That(P1todo.Title.Text, Is.EqualTo(Config.TodoVachevTitle));
        }
        [Test]
        public void DragAndDropPostVisibilityCheck()
        {
            Page_1_Todor_Vachev_Link P1todo = new Page_1_Todor_Vachev_Link(Driver);
            /*Drag and drop check*/
            Assert.That(P1todo.Drag_and_Drop_Post.Text, Is.EqualTo(Config.PostsName.DragAndDrop));
        }
        [Test]
        public void NewTabPostVisibilityCheck()
        {
            Page_1_Todor_Vachev_Link P1todo = new Page_1_Todor_Vachev_Link(Driver);
            /*New Tab Check*/
            Assert.That(P1todo.NewTab_Post.Text, Is.EqualTo(Config.PostsName.NewTab));
        }
        [Test]
        public void AlertBoxPostVisibilityCheck()
        {
            Page_1_Todor_Vachev_Link P1todo = new Page_1_Todor_Vachev_Link(Driver);
            /*Alert Box Post Check*/
            Assert.That(P1todo.AlertBox_Post.Text, Is.EqualTo(Config.PostsName.AlertBoxPost));
        }
        [Test]
        public void NamePostVisibilityCheck()
        {
            Page_1_Todor_Vachev_Link P1todo = new Page_1_Todor_Vachev_Link(Driver);
            /*Name Post Check*/
            Assert.That(P1todo.Name_Post.Text, Is.EqualTo(Config.PostsName.NamePost));
        }
        [Test]
        public void IDPostVisibilityCheck()
        {
            Page_1_Todor_Vachev_Link P1todo = new Page_1_Todor_Vachev_Link(Driver);
            /*ID Post Check*/
            Assert.That(P1todo.ID_Post.Text, Is.EqualTo(Config.PostsName.IDPost));
        }
        [Test]
        public void XPathPostVisibilityCheck()
        {
            Page_1_Todor_Vachev_Link P1todo = new Page_1_Todor_Vachev_Link(Driver);
            /*XPath Post Check*/
            Assert.That(P1todo.XPath_Post.Text, Is.EqualTo(Config.PostsName.XPathPost));
        }
        [Test]
        public void CSSPathPostVisibilityCheck()
        {
            Page_1_Todor_Vachev_Link P1todo = new Page_1_Todor_Vachev_Link(Driver);
            /*CSS Path Post Check*/
            Assert.That(P1todo.CSSPath_Post.Text, Is.EqualTo(Config.PostsName.CSSPathPost));
        }
        [Test]
        public void ClassNamePostVisibilityCheck()
        {
            Page_1_Todor_Vachev_Link P1todo = new Page_1_Todor_Vachev_Link(Driver);
            /*Class Name Post Check*/
            Assert.That(P1todo.ClassName_Post.Text, Is.EqualTo(Config.PostsName.ClassNamePost));
        }
        [Test]
        public void Item_in_Category_Drop_Down_MenuPostVisibilityCheck()
        {
            Page_1_Todor_Vachev_Link P1todo = new Page_1_Todor_Vachev_Link(Driver);
            /*Item in Category Drop Down Menu Post Check*/
            Assert.That(P1todo.Item_in_Category_Drop_Down_Menu_Post.Text, Is.EqualTo(Config.PostsName.ItemsinCategoryDropDownMenuPost));
        }
        [Test]/*Error by Image bug was open */
        public void Login_Button_in_Login_FormPostVisibilityCheck()
        {
            Page_1_Todor_Vachev_Link P1todo = new Page_1_Todor_Vachev_Link(Driver);
            /*Login Button in Login Form Post Check*/
            Assert.That(P1todo.Login_Button_in_Login_Form_Post.Text, Is.EqualTo(Config.PostsName.LoginButtoninLoginFormPost));
        }
        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }






    }
}

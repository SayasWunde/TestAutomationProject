using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using WebTestingProject.UI_Elements;


namespace WebTestingProject.Scenarios
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class Page_2_Todor_Vachev_Link_IsVisible
    {
        public IWebDriver Driver { get; set; }
        [OneTimeSetUp] /*One time set up -- Exuted one time befor all the test below it */
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.Page_2_Todor_Vachev_Link_ThroughNamePost(Driver);
        }

        [Test]/*Title + button 1 + Arrow to button 2 visibality test */
        public void Title_Button1andArrowtoPage1VisibilityCheck()
        {
            Page_2_Todor_Vachev_Link P2Todov = new Page_2_Todor_Vachev_Link(Driver);
            Assert.That(P2Todov.Title.Text, Is.EqualTo(Config.TodoVachevTitle));
        }
        [Test]
        public void Username_Field_in_Login_FormPostVisibilityCheck()
        {
            Page_2_Todor_Vachev_Link P2Todov = new Page_2_Todor_Vachev_Link(Driver);
            /*Username Field in Login form Post Check*/
            Assert.That(P2Todov.Username_Field_in_Login_Form_Post.Text, Is.EqualTo(Config.PostsName.UsernameFieldinLoginFormPost));
        }
        [Test]
        public void LoginFormPostVisibilityCheck()
        {
            Page_2_Todor_Vachev_Link P2Todov = new Page_2_Todor_Vachev_Link(Driver);
            /*Login form Post Check*/
            Assert.That(P2Todov.Login_Form_Post.Text, Is.EqualTo(Config.PostsName.LoginFormPost));
        }
        [Test]
        public void RegisterFormPostVisibilityCheck()
        {
            Page_2_Todor_Vachev_Link P2Todov = new Page_2_Todor_Vachev_Link(Driver);
            /*Register from Post Check*/
            Assert.That(P2Todov.Register_Form_Post.Text, Is.EqualTo(Config.PostsName.RegisterFormPost));
        }
        [Test]
        public void Text_Input_FieldPostVisibilityCheck()
        {
            Page_2_Todor_Vachev_Link P2Todov = new Page_2_Todor_Vachev_Link(Driver);
            /*Text input field Post Check*/
            Assert.That(P2Todov.Text_Input_Field_Post.Text, Is.EqualTo(Config.PostsName.TestInputFieldPost));
        }
        [Test]
        public void Check_Button_TestPostVisibilityCheck()
        {
            Page_2_Todor_Vachev_Link P2Todov = new Page_2_Todor_Vachev_Link(Driver);
            /*Check button test Post Check*/
            Assert.That(P2Todov.Check_Button_Test_Post.Text, Is.EqualTo(Config.PostsName.CheckButtonTestPost));
        }
        [Test]
        public void Radio_Button_TestPostVisibilityCheck()
        {
            Page_2_Todor_Vachev_Link P2Todov = new Page_2_Todor_Vachev_Link(Driver);
            /*Radio button test Post Check*/
            Assert.That(P2Todov.Radio_Button_Test_Post.Text, Is.EqualTo(Config.PostsName.RadioButtonTestPost));
        }
        [Test]
        public void Drop_Down_Menu_TestPostVisibilityCheck()
        {
            Page_2_Todor_Vachev_Link P2Todov = new Page_2_Todor_Vachev_Link(Driver);
            /*Drop down mune test Post Check*/
            Assert.That(P2Todov.Drop_Down_Menu_Test_Post.Text, Is.EqualTo(Config.PostsName.DropdownmenuTestPost));
        }
        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }


    }
}

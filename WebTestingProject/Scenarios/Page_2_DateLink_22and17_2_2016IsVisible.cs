using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Scenarios
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class Page_2_DateLink_22and17_2_2016IsVisible
    {
        public IWebDriver Driver { get; set; }
        [OneTimeSetUp] /*One time set up -- Exuted one time befor all the test below it */
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.Page_2_DateLink_22and17_2_2016ThroughNamePost(Driver);
        }
        [Test]/*Title + button 1 + Arrow to button 2 visibality test */
        public void TitleVisibilityCheck()
        {
            Page_2_DateLink_22and17_2_2016 P2Date = new Page_2_DateLink_22and17_2_2016(Driver);
            Assert.That(P2Date.Title.Text, Is.EqualTo(Config.DateLinkTitle_22and17_2_2016));
        }
        [Test]
        public void RegisterFormPostVisibilityCheck()
        {
            Page_2_DateLink_22and17_2_2016 P2Date = new Page_2_DateLink_22and17_2_2016(Driver);
            /*Register from Post Check*/
            Assert.That(P2Date.RegisterFormPost.Text, Is.EqualTo(Config.PostsName.RegisterFormPost));
        }
        [Test]
        public void Text_Input_FieldPostVisibilityCheck()
        {
            Page_2_DateLink_22and17_2_2016 P2Date = new Page_2_DateLink_22and17_2_2016(Driver);
            /*Text input field Post Check*/
            Assert.That(P2Date.Text_Input_Field_Post.Text, Is.EqualTo(Config.PostsName.TestInputFieldPost));
        }
        [Test]
        public void Check_Button_TestPostVisibilityCheck()
        {
            Page_2_DateLink_22and17_2_2016 P2Date = new Page_2_DateLink_22and17_2_2016(Driver);
            /*Check button test Post Check*/
            Assert.That(P2Date.Check_Button_Test_Post.Text, Is.EqualTo(Config.PostsName.CheckButtonTestPost));
        }
        [Test]
        public void Radio_Button_TestPostVisibilityCheck()
        {
            Page_2_DateLink_22and17_2_2016 P2Date = new Page_2_DateLink_22and17_2_2016(Driver);
            /*Radio button test Post Check*/
            Assert.That(P2Date.Radio_Button_Test_Post.Text, Is.EqualTo(Config.PostsName.RadioButtonTestPost));
        }
        [Test]
        public void Drop_Down_Menu_TestPostVisibilityCheck()
        {
            Page_2_DateLink_22and17_2_2016 P2Date = new Page_2_DateLink_22and17_2_2016(Driver);
            /*Drop down mune test Post Check*/
            Assert.That(P2Date.Drop_Down_Menu_Test_Post.Text, Is.EqualTo(Config.PostsName.DropdownmenuTestPost));
        }
        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}

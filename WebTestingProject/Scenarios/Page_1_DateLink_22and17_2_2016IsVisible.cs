
using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Scenarios
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class Page_1_DateLink_22and17_2_2016IsVisible
    {
        public IWebDriver Driver { get; set; }
        [OneTimeSetUp] /*One time set up -- Exuted one time befor all the test below it */
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.Page_1_DateLink_22and17_2_2016ThroughNamePost(Driver);
        }
        [Test]/*Title + button 2 + Arrow to button 2 visibality test
               */
        public void TitleVisibilityCheck()
        {
            Page_1_DateLink_22and17_2_2016 P1Date = new Page_1_DateLink_22and17_2_2016(Driver);
            Assert.That(P1Date.Title.Text, Is.EqualTo(Config.DateLinkTitle_22and17_2_2016));
        }
        [Test]
        public void AlertBoxPostVisibilityCheck()
        {
            Page_1_DateLink_22and17_2_2016 P1Date = new Page_1_DateLink_22and17_2_2016(Driver);
            /*Alert Box Post Check*/
            Assert.That(P1Date.Alert_BoxPost.Text, Is.EqualTo(Config.PostsName.AlertBoxPost));
        }
        [Test]
        public void NamePostVisibilityCheck()
        {
            Page_1_DateLink_22and17_2_2016 P1Date = new Page_1_DateLink_22and17_2_2016(Driver);
            /*Name Post Check*/
            Assert.That(P1Date.Name_Post.Text, Is.EqualTo(Config.PostsName.NamePost));
        }
        [Test]
        public void IDPostVisibilityCheck()
        {
            Page_1_DateLink_22and17_2_2016 P1Date = new Page_1_DateLink_22and17_2_2016(Driver);
            /*ID Post Check*/
            Assert.That(P1Date.ID_Post.Text, Is.EqualTo(Config.PostsName.IDPost));
        }
        [Test]
        public void XPathPostVisibilityCheck()
        {
            Page_1_DateLink_22and17_2_2016 P1Date = new Page_1_DateLink_22and17_2_2016(Driver);
            /*XPath Post Check*/
            Assert.That(P1Date.XPath_Post.Text, Is.EqualTo(Config.PostsName.XPathPost));
        }
        [Test]
        public void CSSPathPostVisibilityCheck()
        {
            Page_1_DateLink_22and17_2_2016 P1Date = new Page_1_DateLink_22and17_2_2016(Driver);
            /*CSS Path Post Check*/
            Assert.That(P1Date.CSSPath_Post.Text, Is.EqualTo(Config.PostsName.CSSPathPost));
        }
        [Test]
        public void ClassNamePostVisibilityCheck()
        {
            Page_1_DateLink_22and17_2_2016 P1Date = new Page_1_DateLink_22and17_2_2016(Driver);
            /*Class Name Post Check*/
            Assert.That(P1Date.ClassName_Post.Text, Is.EqualTo(Config.PostsName.ClassNamePost));
        }
        [Test]
        public void Item_in_Category_Drop_Down_MenuPostVisibilityCheck()
        {
            Page_1_DateLink_22and17_2_2016 P1Date = new Page_1_DateLink_22and17_2_2016(Driver);
            /*Item in Category Drop Down Menu Post Check*/
            Assert.That(P1Date.Item_in_Category_Drop_Down_Menu_Post.Text, Is.EqualTo(Config.PostsName.ItemsinCategoryDropDownMenuPost));

        }
        [Test]
        public void Login_Button_in_Login_FormPostVisibilityCheck()
        {
            Page_1_DateLink_22and17_2_2016 P1Date = new Page_1_DateLink_22and17_2_2016(Driver);
            /*Login Button in Login Form Post Check*/
            Assert.That(P1Date.Login_Button_in_Login_Form_Post.Text, Is.EqualTo(Config.PostsName.LoginButtoninLoginFormPost));
        }


        [Test]
        public void Username_Field_in_Login_FormPostVisibilityCheck()
        {
            Page_1_DateLink_22and17_2_2016 P1Date = new Page_1_DateLink_22and17_2_2016(Driver);
            /*Username Field in Login form Post Check*/
            Assert.That(P1Date.Username_Field_in_Login_Form_Post.Text, Is.EqualTo(Config.PostsName.UsernameFieldinLoginFormPost));
        }


        [Test]
        public void LoginFormPostVisibilityCheck()
        {
            Page_1_DateLink_22and17_2_2016 P1Date = new Page_1_DateLink_22and17_2_2016(Driver);
            /*Login form Post Check*/
            Assert.That(P1Date.Login_Form_Post.Text, Is.EqualTo(Config.PostsName.LoginFormPost));



        }

        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class LoginButtonInLoginFormPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.LoginButtonInLoginFormPostThroughTheMenu(Driver);
        }
        [Test]
        public void LoginButtonInLoginFormPostPageVisibilityCheck()
        {
            Login_Button_In_Login_Form_Post lbilfp =new Login_Button_In_Login_Form_Post(Driver);
            Assert.That(lbilfp.Title.Text, Is.EqualTo(Config.PostsName.LoginButtoninLoginFormPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }



    }
}

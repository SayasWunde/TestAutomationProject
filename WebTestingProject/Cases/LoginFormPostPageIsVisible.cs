using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class LoginFormPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.LoginFormPostThroughTheMenu(Driver);
        }
        [Test]
        public void LoginFormPostPageVisibilityCheck()
        {
            LoginFormPost loginFormPost = new LoginFormPost(Driver);
            Assert.That(loginFormPost.Title.Text, Is.EqualTo(Config.PostsName.LoginFormPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}

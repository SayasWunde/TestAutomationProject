using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class RegisterFormPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.RegisterFormPostThroughTheMenu(Driver);
        }
        [Test]
        public void RegisterFormPostPageVisibilityCheck()
        {
            RegisterFormPost registerform = new RegisterFormPost(Driver);
            Assert.That(registerform.Title.Text, Is.EqualTo(Config.PostsName.RegisterFormPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }


    }
}

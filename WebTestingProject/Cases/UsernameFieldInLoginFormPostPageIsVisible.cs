using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class UsernameFieldInLoginFormPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.UsernameFieldInLoginFormPostThroughTheMenu(Driver);
        }
        [Test]
        public void UsernameFieldInLoginFormPostPageVisibilityCheck()
        {
            Username_Field_In_Login_Form_Post unfilf = new Username_Field_In_Login_Form_Post(Driver);
            Assert.That(unfilf.Title.Text, Is.EqualTo(Config.PostsName.UsernameFieldinLoginFormPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }



    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class TextInputFieldPostPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.TextInputFieldPostThroughTheMenu(Driver);
        }
        [Test]
        public void TextInputFieldPostPageVisibilityCheck()
        {
            Text_Input_field_Post textinputfield = new Text_Input_field_Post(Driver);
            Assert.That(textinputfield.Title.Text, Is.EqualTo(Config.PostsName.TestInputFieldPost));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }


    }
}

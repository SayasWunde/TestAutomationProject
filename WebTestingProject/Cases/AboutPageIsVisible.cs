using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class AboutPageIsVisible
    {
        public IWebDriver Driver { get; set; }

        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver =Action.InitializeDriver();
            Menu menu = new Menu(Driver);
            menu.About.Click();
        }
        [Test]
        public void AboutPageVisibilityCheck()
        {
            About about = new About(Driver);
            Assert.That(about.Title.Text,Is.EqualTo("About"));  
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}

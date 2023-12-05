
using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    /*[Parallelizable] /*Will make the test run parallele*/
    [Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class HomePageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
        }
        [Test]
        public void HomePageVisibilityCheck()
        {
            HomePage hPage = new HomePage(Driver);
            Assert.That(hPage.HeadlineAboveMenue.Text, Is.EqualTo("SELENIUM WEBDRIVER WITH C#"));
            Assert.That(hPage.SubHeadlineAboveMenu.Text, Is.EqualTo("LEARN HOW TO WRITE TESTS WITH SELENIUM IN C#"));
            Assert.That(hPage.Title.Text, Is.EqualTo("Introduction"));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;


namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class MenuBarIsVisible
    {
        public IWebDriver Driver { get; set; }

        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
           
        }
        [Test]
        public void MenuVisibilityCheck()
        {
            Menu menu = new Menu(Driver);
            Assert.That(menu.Introduction.Text, Is.EqualTo("INTRODUCTION"));
            Assert.That(menu.Selectors.Text, Is.EqualTo("SELECTORS"));
            Assert.That(menu.SpecialElements.Text, Is.EqualTo("SPECIAL ELEMENTS"));
            Assert.That(menu.TestCases.Text, Is.EqualTo("TEST CASES"));
            Assert.That(menu.TestScenarios.Text, Is.EqualTo("TEST SCENARIOS"));
            Assert.That(menu.About.Text, Is.EqualTo("ABOUT"));
        }

        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}

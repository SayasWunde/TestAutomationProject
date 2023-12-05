using NUnit.Framework;
using OpenQA.Selenium;
using System.Xml.Linq;
using WebTestingProject.UI_Elements;


namespace WebTestingProject.Scenarios
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class TestCasesPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [OneTimeSetUp] /*One time set up -- Exuted one time befor all the test below it */
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            Menu menu = new Menu(Driver);
            menu.TestCases.Click();
        }
        [Test]
        public void ItemInCategoryDropDownMenuPostAndTitleVisibilityCheckInTestCasesPage()
        {
            TestCases testCases = new TestCases(Driver);
            /*Item in Category Drop Down Menu*/
            Assert.That(testCases.Title.Text, Is.EqualTo("Test Cases"));
            Assert.That(testCases.ItemInCategory_Post.Text, Is.EqualTo(Config.PostsName.ItemsinCategoryDropDownMenuPost));
        }
        [Test]
        public void LoginButtonInLoginFormPostAndTitleVisibilityCheckInTestCasesPage()
        {
            TestCases testCases = new TestCases(Driver);
            /*Login Button in Login Form*/
            Assert.That(testCases.LogInButtonInLoginForm_Post.Text, Is.EqualTo(Config.PostsName.LoginButtoninLoginFormPost));
        }
        [Test]
        public void UsernameFieldInLoginFormPostAndTitleVisibilityCheckInTestCasesPage()
        {
            TestCases testCases = new TestCases(Driver);
            /*Username Field in Login Form*/
            Assert.That(testCases.UsernameFieldInLogInForm_Post.Text, Is.EqualTo(Config.PostsName.UsernameFieldinLoginFormPost));
        }
        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}

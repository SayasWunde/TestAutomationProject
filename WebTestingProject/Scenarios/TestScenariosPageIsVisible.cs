using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;


namespace WebTestingProject.Scenarios
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class TestScenariosPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [OneTimeSetUp] /*One time set up -- Exuted one time befor all the test below it */
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            Menu menu = new Menu(Driver);
            menu.TestScenarios.Click();
        }
        [Test]
        public void LoginFormPostAndTitleVisibilityCheckInTestTestScenariosPage()
        {
            TestScenarios testScenarios = new TestScenarios(Driver);  
            /*Login Form*/
            Assert.That(testScenarios.Title.Text, Is.EqualTo("Test Scenarios"));
            Assert.That(testScenarios.LogInForm_Post.Text, Is.EqualTo(Config.PostsName.LoginFormPost));
        }
        [Test]
        public void RegisterFormPostVisibilityCheckInTestTestScenariosPage()
        {
            TestScenarios testScenarios = new TestScenarios(Driver);
            /*Register Form*/ 
            Assert.That(testScenarios.RegisterForm_Post.Text, Is.EqualTo(Config.PostsName.RegisterFormPost));
        }
        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }







    }
}

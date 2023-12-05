using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;
namespace WebTestingProject.Scenarios
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class SelectorsPageIsVisible
    {
        public IWebDriver Driver { get; set; }
        [OneTimeSetUp] /*One time set up -- Exuted one time befor all the test below it */
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            Menu menu = new Menu(Driver);
            menu.Selectors.Click();
        }
        [Test]
        public void NamePostAndTitleVisibilityCheckInSelectorPage()
        {
            Selectors select = new Selectors(Driver);
            Assert.That(select.Title.Text, Is.EqualTo("Selectors"));
            /*Name Post Check*/
            Assert.That(select.Name_Post.Text, Is.EqualTo(Config.PostsName.NamePost));
        }
        [Test]
        public void IDPostVisibilityCheckInSelectorPage()
        {
            Selectors select = new Selectors(Driver);
            /*ID Post Check*/
            Assert.That(select.ID_Post.Text, Is.EqualTo(Config.PostsName.IDPost));

        }
        [Test]
        public void XPathPostVisibilityCheckInSelectorPage()
        {
            Selectors select = new Selectors(Driver);
            /*XPath Post Check*/
            Assert.That(select.Xpath_Post.Text, Is.EqualTo(Config.PostsName.XPathPost));

        }
        [Test]
        public void CSSPathPostVisibilityCheckInSelectorPage()
        {
            Selectors select = new Selectors(Driver);
            /*CSS Path Post Check*/
            Assert.That(select.CssPath_Post.Text, Is.EqualTo(Config.PostsName.CSSPathPost));
        }
        [Test]
        public void ClassNamePostVisibilityCheckInSelectorPage()
        {
            Selectors select = new Selectors(Driver);
            /*Class Name Post Check*/
            Assert.That(select.ClassName_Post.Text, Is.EqualTo(Config.PostsName.ClassNamePost));

        }
        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }




    }
}

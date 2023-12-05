using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    public class RightSideBarDropDownListTest
    {
        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
           
        }
        [Test]
        public void RightSideBarCategoriesTest()
        {
            RightSideBar rsbar = new RightSideBar(Driver);
            HomePage homePage = new HomePage(Driver);
            ActionFolder actionF = new ActionFolder(Driver);
            Selectors selectors = new Selectors(Driver);
            SpecialElements specialElements = new SpecialElements(Driver);
            Tabs_and_Windows_Folder tabs = new Tabs_and_Windows_Folder(Driver);
            TestCases testcase = new TestCases(Driver);
            TestScenarios scenarios = new TestScenarios(Driver);
            Assert.That(homePage.Title.Text,Is.EqualTo("Introduction"));
            rsbar.Categories_DropDouwnMenu_Option1_Action.Click();
            Assert.That(actionF.Title.Text, Is.EqualTo("Actions"));
            rsbar.Categories_DropDouwnMenu_Option2_Selectors.Click();
            Assert.That(selectors.Title.Text, Is.EqualTo("Selectors"));
            rsbar.Categories_DropDouwnMenu_Option3_SpecialElements.Click();
            Assert.That(specialElements.Title.Text, Is.EqualTo("Special Elements"));
            rsbar.Categories_DropDouwnMenu_Option4_TabAndWindow.Click();
            Assert.That(tabs.Title.Text, Is.EqualTo("Tabs and Windows"));
            rsbar.Categories_DropDouwnMenu_Option5_TestCase.Click();
            Assert.That(testcase.Title.Text, Is.EqualTo("Test Cases"));
            rsbar.Categories_DropDouwnMenu_Option6_TestScenarios.Click();
            Assert.That(scenarios.Title.Text, Is.EqualTo("Test Scenarios"));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }



    }
}

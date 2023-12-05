using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class NewTabPostIsVisible
    {
        public IWebDriver Driver { get; set; }

        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            RightSideBar rsideb =new RightSideBar(Driver);
            rsideb.RecentPosts_NewTab.Click();
        }
        [Test]
        public void AboutPageVisibilityCheck()
        {
            NewTab_Post newTab = new NewTab_Post(Driver);
            Assert.That(newTab.Title.Text, Is.EqualTo(Config.PostsName.NewTab));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}

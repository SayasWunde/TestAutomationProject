using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Scenarios
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class DropDownMenuTest
    {
        public IWebDriver Driver { get; set; }
        [OneTimeSetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.DropDownMenuTestPostThroughTheMenu(Driver);
        }
        [Test]
        public void InitialValue_Volvo()
        {
            Drop_Down_Menu_Test_Post ddm = new Drop_Down_Menu_Test_Post(Driver);
            Assert.That(ddm.DropDownMenuField.GetAttribute("value"), Is.EqualTo("volvo"));
        }
        [Test]
        public void SelectingSaab()
        {
            Drop_Down_Menu_Test_Post ddm = new Drop_Down_Menu_Test_Post(Driver);
            ddm.DropDownOption_Saab.Click();
            Assert.That(ddm.DropDownMenuField.GetAttribute("value"), Is.EqualTo("saab"));
        }
        [Test]
        public void SelectingMercedes()
        {
            Drop_Down_Menu_Test_Post ddm = new Drop_Down_Menu_Test_Post(Driver);
            ddm.DropDownOption_Mercedes.Click();
            Assert.That(ddm.DropDownMenuField.GetAttribute("value"), Is.EqualTo("mercedes"));
        }
        [Test]
        public void SelectingAudi()
        {
            Drop_Down_Menu_Test_Post ddm = new Drop_Down_Menu_Test_Post(Driver);
            ddm.DropDownOption_Audi.Click();
            Assert.That(ddm.DropDownMenuField.GetAttribute("value"), Is.EqualTo("audi"));
        }

        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}

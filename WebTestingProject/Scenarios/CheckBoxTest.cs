using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Scenarios
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class CheckBoxTest
    {
        public IWebDriver Driver { get; set; }

        [OneTimeSetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.CheckButtonTestPostThroughTheMenu(Driver);
        }
        /*ABCD - Because the order matter*/
        [Test]
        public void ADefaultState()
        {
            Check_Button_Test_Post check = new Check_Button_Test_Post(Driver);
            /*Unchecked*/
            Assert.That(check.CheckBox_IHaveABike.GetAttribute("checked") == "true", Is.EqualTo(false));
            /*Checked*/
            Assert.That(check.CheckBox_IHaveACar.GetAttribute("checked") == "true", Is.EqualTo(true));
        }
        [Test]
        public void BikeCheckedAndCarUnchecked()
        {
            Check_Button_Test_Post check = new Check_Button_Test_Post(Driver);
            check.CheckBox_IHaveABike.Click();
            check.CheckBox_IHaveACar.Click();
            /*Checked*/
            Assert.That(check.CheckBox_IHaveABike.GetAttribute("checked") == "true", Is.EqualTo(true));
            /*Unchecked*/
            Assert.That(check.CheckBox_IHaveACar.GetAttribute("checked") == "true", Is.EqualTo(false));
        }
        [Test]
        public void CBothUnchecked()
        {
            Check_Button_Test_Post check = new Check_Button_Test_Post(Driver);
            Thread.Sleep(2000);
            check.CheckBox_IHaveABike.Click();
            /*Both Unchecked*/
            Assert.That(check.CheckBox_IHaveABike.GetAttribute("checked") == "true", Is.EqualTo(false));
            Assert.That(check.CheckBox_IHaveACar.GetAttribute("checked") == "true", Is.EqualTo(false));
        }
        [Test]
        public void DBothChecked()
        {
            Check_Button_Test_Post check = new Check_Button_Test_Post(Driver);
            Thread.Sleep(2000);
            check.CheckBox_IHaveABike.Click();
            check.CheckBox_IHaveACar.Click();
            Assert.That(check.CheckBox_IHaveABike.GetAttribute("checked") == "true", Is.EqualTo(true));
            Assert.That(check.CheckBox_IHaveACar.GetAttribute("checked") == "true", Is.EqualTo(true));
        }
        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Scenarios
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class RadioButtonTest
    {
        public IWebDriver Driver { get; set; }

        [OneTimeSetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.RadioButtonTestPostThroughTheMenu(Driver);
        }
        [Test]
        public void InitialStateOfRadioButtonElements()
        {
            Radio_Button_Test_Post rbp = new Radio_Button_Test_Post(Driver);
            Assert.That(rbp.RadioButton_Male.GetAttribute("checked"),Is.EqualTo("true"));
            Assert.That(rbp.RadioButton_Female.GetAttribute("checked"), Is.EqualTo(null));
            Assert.That(rbp.RadioButton_Other.GetAttribute("checked"), Is.EqualTo(null));
        }
        [Test]
        public void MaleSelected()
        {
            Radio_Button_Test_Post rbp = new Radio_Button_Test_Post(Driver);
            rbp.RadioButton_Female.Click();
            Assert.That(rbp.RadioButton_Female.GetAttribute("checked"), Is.EqualTo("true"));

        }
        [Test]
        public void OtherSelected()
        {
            Radio_Button_Test_Post rbp = new Radio_Button_Test_Post(Driver);
            rbp.RadioButton_Other.Click();
            Assert.That(rbp.RadioButton_Other.GetAttribute("checked"), Is.EqualTo("true"));
        }
        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}

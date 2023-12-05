
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    /*[Parallelizable] /*Will make the test run parallele*/
    [Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class LoginValidLogin
    {
        public IWebDriver Driver { get; set; }
        IAlert alert;
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.LoginFormPostThroughTheMenu(Driver);
        }
        [Test]
        public void successfulLogin()
        {
            Action.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword,Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.LoginFormPost.SuccesfulLogin));
            alert.Accept();
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }


    }
}

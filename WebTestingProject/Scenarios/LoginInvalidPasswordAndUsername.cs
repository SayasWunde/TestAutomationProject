

using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Scenarios
{
    /*[Parallelizable] /*Will make the test run parallele*/
    [Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class LoginInvalidPasswordAndUsername
    {
        public IWebDriver Driver { get; set; }
        IAlert alert;
        [OneTimeSetUp] /*set up -Excuted befor every test |One time set up -- Exuted one time befor all the test below it */
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.LoginFormPostThroughTheMenu(Driver);
        }
        [Test]
        public void PasswordLessThen5Chars()
        {    
            Action.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.SixCharacters, Config.Credentials.Invalid.Password.SixCharacters,Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.LoginFormPost.InvalidPassword));
            alert.Accept();
        }
        [Test]
        public void PasswordMoreThen12Chars()
        {
            Action.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.LoginFormPost.InvalidPassword));
            alert.Accept();
        }
        [Test]
        public void PassWordsDontMatch()
        {
            Action.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Valid.Password, Config.Credentials.Invalid.Password.PassDontMatch, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.LoginFormPost.PasswordDoNotMatch));
            alert.Accept();
        }
        [Test]
        public void PasswordFieldEmpty()
        {
            Action.FillLoginFormPasswordFieldEmpty(Config.Credentials.Valid.Username,Config.Credentials.Valid.RepeatPassword,Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.LoginFormPost.InvalidPassword));
            alert.Accept();
        }
        [Test]
        public void RepeatPasswordFieldEmpty()
        {
            Action.FillLoginFormRepeatPasswordFieldEmpty(Config.Credentials.Valid.Username,Config.Credentials.Valid.Password, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.LoginFormPost.PasswordDoNotMatch));
            alert.Accept();
        }

        [Test] /*Enter in the username field less then 5 characters , and valid password*/
        public void UsernameLessThen5Chars()
        {
            Action.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.LoginFormPost.InvalidUserName));
            alert.Accept();
        }
        [Test]/*Enter in the username field Morethen 12 Characters  , and valid password*/
        public void UsernameMorethen12Chars()
        {
            Action.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.LoginFormPost.InvalidUserName));
            alert.Accept();
        }
        [Test]/*Leave username field empty , and valid password*/
        public void EmptyUsernameField()
        {
            Action.FillLoginFormUsernameFieldEmpty(Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.LoginFormPost.InvalidUserName));
            alert.Accept();
        }

        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }


    }
}

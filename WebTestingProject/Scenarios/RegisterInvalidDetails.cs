using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Scenarios
{
    [Parallelizable] /*Will make the test run parallele*/
    /*[Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class RegisterInvalidDetails
    {
        public IWebDriver Driver { get; set; }
        IAlert alert;
        [OneTimeSetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.RegisterFormPostThroughTheMenu(Driver);
        }
        [Test]
        public void UserIdLessThen5Characters()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterForm(Config.Credentials.Invalid.Username.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidUserID));
            alert.Accept();
        }
        [Test]
        public void UserIdMoreThen12Characters()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterForm(Config.Credentials.Invalid.Username.ThirteenCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidUserID));
            alert.Accept();
        }
        [Test]
        public void UserIdFieldEmpty()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterFormUserIdEmpty(Config.Credentials.Valid.Password, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidUserID));
            alert.Accept();
        }

        [Test]
        public void PasswordLessThen7Character()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterForm(Config.Credentials.Valid.UserID, Config.Credentials.Invalid.Password.SixCharacters, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidPassword));
            alert.Accept();
        }
        [Test]
        public void PasswordMoreThen12Characters()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterForm(Config.Credentials.Valid.UserID, Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidPassword));
            alert.Accept();
        }
        [Test]
        public void PasswordfieldEmpty()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterFormPasswordFieldEmpty(Config.Credentials.Valid.UserID, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidPassword));
            alert.Accept();
        }
        [Test]
        public void NameFieldWithNumbers()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterForm(Config.Credentials.Valid.UserID, Config.Credentials.Valid.Password, Config.Credentials.Invalid.Password.SixCharacters, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidName));
            alert.Accept();
        }
        [Test]
        public void NameFieldEmpty()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterFormNameFieldEmpty(Config.Credentials.Valid.UserID, Config.Credentials.Valid.Password, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidName));
            alert.Accept();
        }

        [Test]
        public void AddressFieldEmpty()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterFormAddressEmpty(Config.Credentials.Valid.UserID, Config.Credentials.Valid.Password, Config.Credentials.Valid.Name,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidAddress));
            alert.Accept();
        }

        [Test]
        public void CountryWasNotSelected()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterFormWithoutSelectingCountry(Config.Credentials.Valid.UserID, Config.Credentials.Valid.Password, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.CountryWasNotChosen));
            alert.Accept();
        }

        [Test]
        public void ZipCodeWithLetters()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterForm(Config.Credentials.Valid.UserID, Config.Credentials.Valid.Password, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
            Config.Credentials.Invalid.Username.FourCharacters, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidZipCode));
            alert.Accept();
        }
        public void EmptyZipCode()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterFormEmptyZipCode(Config.Credentials.Valid.UserID, Config.Credentials.Valid.Password, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
             Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidZipCode));
            alert.Accept();
        }
        [Test]
        public void EmailFieldInvalidEmail()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterForm(Config.Credentials.Valid.UserID, Config.Credentials.Valid.Password, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Invalid.Email.Short, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidEmailAddress));
            alert.Accept();
        }
        [Test]
        public void EmailFieldEmptyEmail()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterFormEmptyEmail(Config.Credentials.Valid.UserID, Config.Credentials.Valid.Password, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Abouttext, Driver);
            alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.InvalidEmailAddress));
            alert.Accept();
        }

        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }


    }
}

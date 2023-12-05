

using NUnit.Framework;
using OpenQA.Selenium;
using WebTestingProject.UI_Elements;

namespace WebTestingProject.Cases
{
    /*[Parallelizable] /*Will make the test run parallele*/
    [Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class RegisterValidTest
    {

        public IWebDriver Driver { get; set; }
        [SetUp] /*set up -Excuted befor every test*/
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.RegisterFormPostThroughTheMenu(Driver);
        }
        [Test]
        public void RegisterValid()
        {
            RegisterFormPost rfPost = new RegisterFormPost(Driver);
            Action.FillRegisterForm(Config.Credentials.Valid.UserID, Config.Credentials.Valid.Password, Config.Credentials.Valid.Name, Config.Credentials.Valid.Address,
            Config.Credentials.Valid.Zipcode, Config.Credentials.Valid.Email, Config.Credentials.Valid.Abouttext,Driver);
            Assert.That(rfPost.Title.Text, Is.EqualTo(Config.alertMessages.RegisterFormPost.RegisterFormTitle));
        }
        [TearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}

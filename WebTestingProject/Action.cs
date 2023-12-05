
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using WebTestingProject.UI_Elements;


namespace WebTestingProject
{
    public  class Action
    {
        public static IWebDriver InitializeDriver()
        {
            /*So each class could initialize its own driver */
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);/*URL land in homePage*/
            /*Implecet wait 5 seconde*/
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            return driver;
        }
        public static void FillLoginForm(string username,string password,string repeatPassword,IWebDriver driver)
        {
            LoginFormPost lfPost = new LoginFormPost(driver);
            lfPost.UserNameField.Clear();
            lfPost.UserNameField.SendKeys(username);
            lfPost.PasswordField.Clear();
            lfPost.PasswordField.SendKeys(password);
            lfPost.RepeatPasswordField.Clear();
            lfPost.RepeatPasswordField.SendKeys(repeatPassword);
            lfPost.LoginButton.Click();         
        }
        public static void FillLoginFormUsernameFieldEmpty(string password,string repeatPassword, IWebDriver driver)
        {
            LoginFormPost lfPost = new LoginFormPost(driver);
            lfPost.UserNameField.Clear();
            lfPost.PasswordField.Clear();
            lfPost.PasswordField.SendKeys(password);
            lfPost.RepeatPasswordField.Clear();
            lfPost.RepeatPasswordField.SendKeys(repeatPassword);
            lfPost.LoginButton.Click();
        }
        public static void FillLoginFormPasswordFieldEmpty(string username, string repeatPassword, IWebDriver driver)
        {
            LoginFormPost lfPost = new LoginFormPost(driver);
            lfPost.UserNameField.Clear();
            lfPost.UserNameField.SendKeys(username);
            lfPost.PasswordField.Clear();
            lfPost.RepeatPasswordField.Clear();
            lfPost.RepeatPasswordField.SendKeys(repeatPassword);
            lfPost.LoginButton.Click();
        }
        public static void FillLoginFormRepeatPasswordFieldEmpty(string username, string password, IWebDriver driver)
        {
            LoginFormPost lfPost = new LoginFormPost(driver);
            lfPost.UserNameField.Clear();
            lfPost.UserNameField.SendKeys(username);
            lfPost.PasswordField.Clear();
            lfPost.PasswordField.SendKeys(password);
            lfPost.RepeatPasswordField.Clear();
            lfPost.LoginButton.Click();
        }
        /*Argument to provide ------------ (new Actions(driver),from-elements[2],to-elements[4])*/
        public static void MoveElement(Actions actions, IWebElement from, IWebElement to)
        {
            actions.ClickAndHold(from)
                .MoveToElement(to)
                .MoveByOffset(0, 10)
                .Release().Build()
                .Perform();
        }
        /*Hover on an Element --------------*/
        ///actions.MoveToElement(elements[0]).Build().Perform();
        public static void HoverOnElement(Actions actions, IWebElement ElementToHoverOn)
        {
            actions.MoveToElement(ElementToHoverOn).Build().Perform();
        }

        /*Find the colore of Element Befor and after you hover above them ------------*/
        /*Console.WriteLine(elements[0].GetCssValue("background-color"));*/
        public static void FillRegisterForm(string userId,string password,string name,
        string address,string zipCode,string email, string aboutText, IWebDriver driver)
        {
            RegisterFormPost rfPost = new RegisterFormPost(driver);
            rfPost.UserIDField.Clear();
            rfPost.UserIDField.SendKeys(userId);
            rfPost.PasswordField.Clear();
            rfPost.PasswordField.SendKeys(password);
            rfPost.NameField.Clear();
            rfPost.NameField.SendKeys(name);
            rfPost.AddressField.Clear();
            rfPost.AddressField.SendKeys(address);        
            rfPost.DDM_Option_Australia.Click();
            rfPost.DDM_Option_Canada.Click();
            rfPost.DDM_Option_India.Click();
            rfPost.DDM_Option_USA.Click();
            rfPost.ZipCodeField.Clear();
            rfPost.ZipCodeField.SendKeys(zipCode);
            rfPost.EmailField.Clear();
            rfPost.EmailField.SendKeys(email); 
            rfPost.RadioButton_Male_Option.Click();
            rfPost.AboutField.Clear();
            rfPost.AboutField.SendKeys(aboutText);
            rfPost.RigesterButton.Click();
           
        }

        public static void FillRegisterFormUserIdEmpty( string password, string name,
       string address, string zipCode, string email, string aboutText, IWebDriver driver)
        {
            RegisterFormPost rfPost = new RegisterFormPost(driver);
            rfPost.UserIDField.Clear();
          
            rfPost.PasswordField.Clear();
            rfPost.PasswordField.SendKeys(password);
            rfPost.NameField.Clear();
            rfPost.NameField.SendKeys(name);
            rfPost.AddressField.Clear();
            rfPost.AddressField.SendKeys(address);
            rfPost.DDM_Option_Australia.Click();
            rfPost.DDM_Option_Canada.Click();
            rfPost.DDM_Option_India.Click();
            rfPost.DDM_Option_USA.Click();
            rfPost.ZipCodeField.Clear();
            rfPost.ZipCodeField.SendKeys(zipCode);
            rfPost.EmailField.Clear();
            rfPost.EmailField.SendKeys(email);
            rfPost.RadioButton_Male_Option.Click();
            rfPost.AboutField.Clear();
            rfPost.AboutField.SendKeys(aboutText);
            rfPost.RigesterButton.Click();

        }

        public static void FillRegisterFormPasswordFieldEmpty(string userId, string name,
       string address, string zipCode, string email, string aboutText, IWebDriver driver)
        {
            RegisterFormPost rfPost = new RegisterFormPost(driver);
            rfPost.UserIDField.Clear();
            rfPost.UserIDField.SendKeys(userId);
            rfPost.PasswordField.Clear();
           
            rfPost.NameField.Clear();
            rfPost.NameField.SendKeys(name);
            rfPost.AddressField.Clear();
            rfPost.AddressField.SendKeys(address);
            rfPost.DDM_Option_Australia.Click();
            rfPost.DDM_Option_Canada.Click();
            rfPost.DDM_Option_India.Click();
            rfPost.DDM_Option_USA.Click();
            rfPost.ZipCodeField.Clear();
            rfPost.ZipCodeField.SendKeys(zipCode);
            rfPost.EmailField.Clear();
            rfPost.EmailField.SendKeys(email);
            rfPost.RadioButton_Male_Option.Click();
            rfPost.AboutField.Clear();
            rfPost.AboutField.SendKeys(aboutText);
            rfPost.RigesterButton.Click();

        }

        public static void FillRegisterFormNameFieldEmpty(string userId, string password,
       string address, string zipCode, string email, string aboutText, IWebDriver driver)
        {
            RegisterFormPost rfPost = new RegisterFormPost(driver);
            rfPost.UserIDField.Clear();
            rfPost.UserIDField.SendKeys(userId);
            rfPost.PasswordField.Clear();
            rfPost.PasswordField.SendKeys(password);
            rfPost.NameField.Clear();
           
            rfPost.AddressField.Clear();
            rfPost.AddressField.SendKeys(address);
            rfPost.DDM_Option_Australia.Click();
            rfPost.DDM_Option_Canada.Click();
            rfPost.DDM_Option_India.Click();
            rfPost.DDM_Option_USA.Click();
            rfPost.ZipCodeField.Clear();
            rfPost.ZipCodeField.SendKeys(zipCode);
            rfPost.EmailField.Clear();
            rfPost.EmailField.SendKeys(email);
            rfPost.RadioButton_Male_Option.Click();
            rfPost.AboutField.Clear();
            rfPost.AboutField.SendKeys(aboutText);
            rfPost.RigesterButton.Click();

        }


        public static void FillRegisterFormAddressEmpty(string userId, string password, string name,
       string zipCode, string email, string aboutText, IWebDriver driver)
        {
            RegisterFormPost rfPost = new RegisterFormPost(driver);
            rfPost.UserIDField.Clear();
            rfPost.UserIDField.SendKeys(userId);
            rfPost.PasswordField.Clear();
            rfPost.PasswordField.SendKeys(password);
            rfPost.NameField.Clear();
            rfPost.NameField.SendKeys(name);
            rfPost.AddressField.Clear();
            
            rfPost.DDM_Option_Australia.Click();
            rfPost.DDM_Option_Canada.Click();
            rfPost.DDM_Option_India.Click();
            rfPost.DDM_Option_USA.Click();
            rfPost.ZipCodeField.Clear();
            rfPost.ZipCodeField.SendKeys(zipCode);
            rfPost.EmailField.Clear();
            rfPost.EmailField.SendKeys(email);
            rfPost.RadioButton_Male_Option.Click();
            rfPost.AboutField.Clear();
            rfPost.AboutField.SendKeys(aboutText);
            rfPost.RigesterButton.Click();

        }

        public static void FillRegisterFormWithoutSelectingCountry(string userId, string password, string name,
       string address, string zipCode, string email, string aboutText, IWebDriver driver)
        {
            RegisterFormPost rfPost = new RegisterFormPost(driver);
            rfPost.UserIDField.Clear();
            rfPost.UserIDField.SendKeys(userId);
            rfPost.PasswordField.Clear();
            rfPost.PasswordField.SendKeys(password);
            rfPost.NameField.Clear();
            rfPost.NameField.SendKeys(name);
            rfPost.AddressField.Clear();
            rfPost.AddressField.SendKeys(address);
       
            rfPost.ZipCodeField.Clear();
            rfPost.ZipCodeField.SendKeys(zipCode);
            rfPost.EmailField.Clear();
            rfPost.EmailField.SendKeys(email);
            rfPost.RadioButton_Male_Option.Click();
            rfPost.AboutField.Clear();
            rfPost.AboutField.SendKeys(aboutText);
            rfPost.RigesterButton.Click();

        }

        public static void FillRegisterFormEmptyZipCode(string userId, string password, string name,
        string address, string email, string aboutText, IWebDriver driver)
        {
            RegisterFormPost rfPost = new RegisterFormPost(driver);
            rfPost.UserIDField.Clear();
            rfPost.UserIDField.SendKeys(userId);
            rfPost.PasswordField.Clear();
            rfPost.PasswordField.SendKeys(password);
            rfPost.NameField.Clear();
            rfPost.NameField.SendKeys(name);
            rfPost.AddressField.Clear();
            rfPost.AddressField.SendKeys(address);
            rfPost.DDM_Option_Australia.Click();
            rfPost.DDM_Option_Canada.Click();
            rfPost.DDM_Option_India.Click();
            rfPost.DDM_Option_USA.Click();
            rfPost.ZipCodeField.Clear();
          
            rfPost.EmailField.Clear();
            rfPost.EmailField.SendKeys(email);
            rfPost.RadioButton_Male_Option.Click();
            rfPost.AboutField.Clear();
            rfPost.AboutField.SendKeys(aboutText);
            rfPost.RigesterButton.Click();

        }

        public static void FillRegisterFormEmptyEmail(string userId, string password, string name,
       string address, string zipCode, string aboutText, IWebDriver driver)
        {
            RegisterFormPost rfPost = new RegisterFormPost(driver);
            rfPost.UserIDField.Clear();
            rfPost.UserIDField.SendKeys(userId);
            rfPost.PasswordField.Clear();
            rfPost.PasswordField.SendKeys(password);
            rfPost.NameField.Clear();
            rfPost.NameField.SendKeys(name);
            rfPost.AddressField.Clear();
            rfPost.AddressField.SendKeys(address);
            rfPost.DDM_Option_Australia.Click();
            rfPost.DDM_Option_Canada.Click();
            rfPost.DDM_Option_India.Click();
            rfPost.DDM_Option_USA.Click();
            rfPost.ZipCodeField.Clear();
            rfPost.ZipCodeField.SendKeys(zipCode);
            rfPost.EmailField.Clear();
           
            rfPost.RadioButton_Male_Option.Click();
            rfPost.AboutField.Clear();
            rfPost.AboutField.SendKeys(aboutText);
            rfPost.RigesterButton.Click();

        }





        public static void acceptAlert(IWebDriver driver)
        {
            IAlert alert = driver.SwitchTo().Alert();
            //Console.WriteLine(alert.Text);
            alert.Accept();
        }
        public static bool IsElementPresent(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch(StaleElementReferenceException)
            {
                return false;
            }

        }

    }
}

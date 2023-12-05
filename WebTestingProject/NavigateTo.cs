
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Xml.Linq;
using WebTestingProject.UI_Elements;
using NUnit.Framework;
using System.Threading;

namespace WebTestingProject
{
    public static class NavigateTo
    {
        /*Selectors*/
        public static void NamePostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            Selectors selectors = new Selectors(driver);
            menu.Selectors.Click();
            selectors.Name_Post.Click();
        }
        public static void IDPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            Selectors selectors = new Selectors(driver);
            menu.Selectors.Click();
            selectors.ID_Post.Click();
        }
        public static void XPathPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            Selectors selectors = new Selectors(driver);
            menu.Selectors.Click();
            selectors.Xpath_Post.Click();
        }
        public static void CSSPathPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            Selectors selectors = new Selectors(driver);
            menu.Selectors.Click();
            selectors.CssPath_Post.Click();
        }
        public static void ClassNamePostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            Selectors selectors = new Selectors(driver);
            menu.Selectors.Click();
            selectors.ClassName_Post.Click();
        }
        /*Special elements*/
        public static void AlertBoxPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            SpecialElements sElements = new SpecialElements(driver);
            menu.SpecialElements.Click();
            sElements.AlertBox_Post.Click();
            Action.acceptAlert(driver);
        }
        public static void TextInputFieldPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            SpecialElements sElements = new SpecialElements(driver);
            menu.SpecialElements.Click();
            sElements.TextInputField_Post.Click();
        }
        public static void CheckButtonTestPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            SpecialElements sElements = new SpecialElements(driver);
            menu.SpecialElements.Click();
            sElements.CheckButtonTest_Post.Click();
        }
        public static void RadioButtonTestPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            SpecialElements sElements = new SpecialElements(driver);
            menu.SpecialElements.Click();
            sElements.RadioButtonTest_Post.Click();
        }
        public static void DropDownMenuTestPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            SpecialElements sElements = new SpecialElements(driver);
            menu.SpecialElements.Click();
            sElements.DropDwonMenuTest_Post.Click();
        }
        /*Test Cases*/
        public static void ItemInCategoryDropDownMenuPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCases testCases = new TestCases(driver);
            menu.TestCases.Click();
            testCases.ItemInCategory_Post.Click();
        }
        public static void LoginButtonInLoginFormPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCases testCases = new TestCases(driver);
            menu.TestCases.Click();
            testCases.LogInButtonInLoginForm_Post.Click();
        }
        public static void UsernameFieldInLoginFormPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCases testCases = new TestCases(driver);
            menu.TestCases.Click();
            testCases.UsernameFieldInLogInForm_Post.Click();
        }
        /*Test Scenarios*/
        public static void LoginFormPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestScenarios testScenarios = new TestScenarios(driver);
            menu.TestScenarios.Click();
            testScenarios.LogInForm_Post.Click();
        }
        public static void RegisterFormPostThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestScenarios testScenarios = new TestScenarios(driver);
            menu.TestScenarios.Click();
            testScenarios.RegisterForm_Post.Click();
        }

        public static void DragAndDropPage(IWebDriver driver)
        {
            RightSideBar rsBar = new RightSideBar(driver);
            DragAndDrop_In_Action_Folder dadActions = new DragAndDrop_In_Action_Folder(driver);
            ActionFolder actionf = new ActionFolder(driver);
            rsBar.Categories_DropDouwnMenu_Option1_Action.Click();
            actionf.DragAndDropPost.Click();
            dadActions.LinkToDraganddropPage.Click();
        }


        public static void Page_1_DateLink_22and17_2_2016ThroughNamePost(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            Selectors selectors = new Selectors(driver);
            NamePost namePost = new NamePost(driver);
            menu.Selectors.Click();
            selectors.Name_Post.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            namePost.DateLink.Click();
        }

        public static void Page_2_DateLink_22and17_2_2016ThroughNamePost(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            Selectors selectors = new Selectors(driver);
            NamePost namePost = new NamePost(driver);
            Page_1_DateLink_22and17_2_2016 p1DL = new Page_1_DateLink_22and17_2_2016(driver);
            menu.Selectors.Click();
            selectors.Name_Post.Click();
            namePost.DateLink.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            p1DL.Button_2_Below.Click();
        }

        public static void Page_1_Todor_Vachev_Link_ThroughNamePost(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            Selectors selectors = new Selectors(driver);
            NamePost namePost = new NamePost(driver);
            Page_1_DateLink_22and17_2_2016 p1DL = new Page_1_DateLink_22and17_2_2016(driver);
            menu.Selectors.Click();
            selectors.Name_Post.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            namePost.TodorVachevLink.Click();
           

        }

        public static void Page_2_Todor_Vachev_Link_ThroughNamePost(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            Selectors selectors = new Selectors(driver);
            NamePost namePost = new NamePost(driver);
            Page_1_Todor_Vachev_Link P1Todovarchev = new Page_1_Todor_Vachev_Link(driver);
            menu.Selectors.Click();
            selectors.Name_Post.Click();
            namePost.TodorVachevLink.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            P1Todovarchev.Button_2_Below.Click();

        }

        public static void LoginPostThroughTheUsernameFieldInLoginFormPost(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCases testCases = new TestCases(driver);
            Username_Field_In_Login_Form_Post Ufilfp = new Username_Field_In_Login_Form_Post(driver);
            menu.TestCases.Click();
            testCases.UsernameFieldInLogInForm_Post.Click();
            Ufilfp.LinkInDescription.Click();
        }





    }
}


//using OpenQA.Selenium.DevTools.V117.WebAuthn;

namespace WebTestingProject
{
    public class Config
    {
        public static string BaseURL = "https://testing.todorvachev.com/";

        public static string DateLinkTitle_22and17_2_2016 = "Month: February 2016";

        public static string DateLinkTitle_29and26_2_2017 = "Month: April 2017";

        public static string TodoVachevTitle = "Articles by Todor Vachev";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@example.com";
                public static string UserID = "ValidUser";               
                public static string Name = "Sayas";
                public static string Address = "Rehovot";
                public static string Zipcode = "12345";
                public static string Abouttext = "Hellow,my name is Sayas";
            }
            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "Absd";
                    public static string ThirteenCharacters = "Asdfghjkloiuy";
                }
                public static class Password
                {
                    public static string SixCharacters = "1234";
                    public static string PassDontMatch = "12356G";
                    public static string ThirteenCharacters = "Asdfghyt8765!";
                }
                public static class Email
                {
                    public static string Short = "Absd";
                    public static string Long = "jfdjhvytjfjvtfuyvfjtvfytvtfjfyt2@jyvtfytfjvthytfuy.com";
                }
            }
        }

        public static class alertMessages 
        {
            public static class LoginFormPost
            {
                public static string SuccesfulLogin = "Succesful login!";
                public static string InvalidUserName = "User Id should not be empty / length be between 5 to 12";
                public static string InvalidPassword = "Password should not be empty / length be between 5 to 12";
                public static string PasswordDoNotMatch = "Passwords do not match!";
            }
            public static class RegisterFormPost
            {
                public static string RegisterFormTitle = "Register Form";
                public static string InvalidUserID = "User Id should not be empty / length be between 5 to 12";
                public static string InvalidPassword = "Password should not be empty / length be between 7 to 12";
                public static string InvalidName = "Username must have alphabet characters only";
                public static string InvalidAddress = "User address must have alphanumeric characters only";
                public static string CountryWasNotChosen = "Select your country from the list";
                public static string InvalidZipCode = "ZIP code must have numeric characters only";
                public static string InvalidEmailAddress = "You have entered an invalid email address!";
            }
            public static string AlerBoxtPostEnterMessage = "Hello! I am Alert Box! Click \"OK\" to dismiss me!";

        }
    
        public static class PostsName
        {
            /*Selector Page*/
            public static string NamePost = "Name";
            public static string IDPost ="ID";
            public static string XPathPost = "XPath";
            public static string CSSPathPost = "CSS Path";
            public static string ClassNamePost = "Class Name";
            /*Special Elements Page*/
            public static string AlertBoxPost = "Alert Box";
            public static string TestInputFieldPost = "Text Input Field";
            public static string CheckButtonTestPost = "Check Button Test";
            public static string RadioButtonTestPost = "Radio Button Test";
            public static string DropdownmenuTestPost = "Drop down menu Test";
            /*Test Cases Page*/
            public static string ItemsinCategoryDropDownMenuPost = "Items in Category Drop Down Menu";
            public static string LoginButtoninLoginFormPost = "Login Button in Login Form";
            public static string UsernameFieldinLoginFormPost = "Username Field in Login Form";
            /*Test Scenarios Page*/
            public static string LoginFormPost = "Login Form";
            public static string RegisterFormPost = "Register Form";
            /*Action*/
            public static string DragAndDrop = "Drag and Drop";
            public static string DragAnddropPageTitle = "Drag and Sort elements";
            /*Tabs and Windows*/
            public static string NewTab = "New Tab";
        }

    }
}

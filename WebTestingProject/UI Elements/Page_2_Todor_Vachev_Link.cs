
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class Page_2_Todor_Vachev_Link
    {
        public Page_2_Todor_Vachev_Link(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        /*All the post from Date link 22/2/2016 and 17/2/2016 , they both lead to the same page*/
        /*Title*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/div/nav/div/a[2]")]
        public IWebElement Button_1_Below { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/div/nav/div/a[1]")]
        public IWebElement Button_Arrow_Below { get; set; }

        /*Username Field in Login Form*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/h3/a")]
        public IWebElement Username_Field_in_Login_Form_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Username_Field_in_Login_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_Username_Field_in_Login_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/div/div/p")]
        public IWebElement ShortDescription_Username_Field_in_Login_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/figure/a/img")]
        public IWebElement Image_Username_Field_in_Login_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_Username_Field_in_Login_Form { get; set; }

        /*Login Form*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/h3/a")]
        public IWebElement Login_Form_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Login_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_Login_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/div/div/p")]
        public IWebElement ShortDescription_Login_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/figure/a/img")]
        public IWebElement Image_Login_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_Login_Form { get; set; }

        /*Register Form*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/h3/a")]
        public IWebElement Register_Form_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Register_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_Register_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/div/div/p")]
        public IWebElement ShortDescription_Register_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/figure/a/img")]
        public IWebElement Image_Register_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_Register_Form { get; set; }

        /*Text Input Field*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/h3/a")]
        public IWebElement Text_Input_Field_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Text_Input_Field { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_Text_Input_Field { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/div/div/p")]
        public IWebElement ShortDescription_Text_Input_Field { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/figure/a/img")]
        public IWebElement Image_Text_Input_Field { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_Text_Input_Field { get; set; }

        /*Check Button Test*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/h3/a")]
        public IWebElement Check_Button_Test_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Check_Button_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_Check_Button_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/div/div/p")]
        public IWebElement ShortDescription_Check_Button_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/figure/a/img")]
        public IWebElement Image_Check_Button_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_Check_Button_Test { get; set; }

        /*Radio Button Test*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/div/header/h3/a")]
        public IWebElement Radio_Button_Test_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Radio_Button_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_Radio_Button_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/div/div/div/p")]
        public IWebElement ShortDescription_Radio_Button_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/figure/a/img")]
        public IWebElement Image_Radio_Button_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_Radio_Button_Test { get; set; }


        /*Drop Down Menu Test*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/div/header/h3/a")]
        public IWebElement Drop_Down_Menu_Test_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Drop_Down_Menu_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_Drop_Down_Menu_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/div/div/div/p")]
        public IWebElement ShortDescription_Drop_Down_Menu_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/figure/a/img")]
        public IWebElement Image_Drop_Down_Menu_Test { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_Drop_Down_Menu_Test { get; set; }
    }
}


using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class Page_1_Todor_Vachev_Link
    {
        public Page_1_Todor_Vachev_Link(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        
        /*Title*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/div/nav/div/a[1]")]
        public IWebElement Button_2_Below { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/div/nav/div/a[2]")]
        public IWebElement Button_Arrow_Below { get; set; }

        /*Drag and Drop*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/h3/a")]
        public IWebElement Drag_and_Drop_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Drag_and_Drop { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_Drag_and_Drop { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/div/div/p")]
        public IWebElement ShortDescription_Drag_and_Drop { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/figure/a/img")]
        public IWebElement Image_Drag_and_Drop { get; set; }

        /*New Tab*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/h3/a")]
        public IWebElement NewTab_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_NewTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_NewTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/div/div/p")]
        public IWebElement ShortDescription_NewTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/div/div/p")]
        public IWebElement Image_NewTab { get; set; }

        /*Alert Box*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/h3/a")]
        public IWebElement AlertBox_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_AlertBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_AlertBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/div/div/p")]
        public IWebElement ShortDescription_AlertBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/figure/a/img")]
        public IWebElement Image_AlertBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_AlertBox { get; set; }

        /*Name*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/h3/a")]
        public IWebElement Name_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/div/div/p")]
        public IWebElement ShortDescription_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/figure/a/img")]
        public IWebElement Image_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_Name { get; set; }

        /*ID*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/h3/a")]
        public IWebElement ID_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_ID { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_ID { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/div/div/p")]
        public IWebElement ShortDescription_ID { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/figure/a/img")]
        public IWebElement Image_ID { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_ID { get; set; }
        
        /*XPath*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/div/header/h3/a")]
        public IWebElement XPath_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_XPath { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_XPath { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/div/div/div/p")]
        public IWebElement ShortDescription_XPath { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/figure/a/img")]
        public IWebElement Image_XPath { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[6]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_XPath { get; set; }


        /*CSS Path*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/div/header/h3/a")]
        public IWebElement CSSPath_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_CSSPath { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_CSSPath { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/div/div/div/p")]
        public IWebElement ShortDescription_CSSPath { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/figure/a/img")]
        public IWebElement Image_CSSPath { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[7]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_CSSPath { get; set; }

        /*Class Name*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[8]/div/header/h3/a")]
        public IWebElement ClassName_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[8]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_ClassName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[8]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_ClassName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[8]/div/div/div/p")]
        public IWebElement ShortDescription_ClassName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[8]/figure/a/img")]
        public IWebElement Image_ClassName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[8]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_ClassName { get; set; }

        /*Item in Category Drop Down Menu*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[9]/div/header/h3/a")]
        public IWebElement Item_in_Category_Drop_Down_Menu_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[9]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Item_in_Category_Drop_Down_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[9]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_Item_in_Category_Drop_Down_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[9]/div/div/div/p")]
        public IWebElement ShortDescription_Item_in_Category_Drop_Down_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[9]/figure/a/img")]
        public IWebElement Image_Item_in_Category_Drop_Down_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[9]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_Item_in_Category_Drop_Down_Menu { get; set; }


        /*Login Button in Login Form*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[10]/div/header/h3/a")]
        public IWebElement Login_Button_in_Login_Form_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[10]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Login_Button_in_Login_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[10]/div/header/div/span[3]/a")]
        public IWebElement CommentLink_Login_Button_in_Login_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[10]/div/div/div/p")]
        public IWebElement ShortDescription_Login_Button_in_Login_Form { get; set; }
        /*Image below cant be fount by XPath and By CSS Selector*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[10]/figure/a/img")]
        public IWebElement Image_Login_Button_in_Login_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[10]/div/div/div/p/a")]
        public IWebElement ReadMoreLink_Login_Button_in_Login_Form { get; set; }


    }
}

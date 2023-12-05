
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class Date_Link_29and26_2_2017
    {
        public Date_Link_29and26_2_2017(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
       
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/header/h1")]
        public IWebElement Title { get; set; }

        /*Drag and Drop*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/h3/a")]
        public IWebElement Drag_and_Drop_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_Drag_and_Drop { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[3]/a")]
        public IWebElement CommentsLink_Drag_and_Drop { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/div/div/p")]
        public IWebElement ShortDescription_Drag_and_Drop { get; set; }

        /*Missing image*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/figure/a/img")]
        public IWebElement Image_Drag_and_Drop { get; set; }

        /*New Tab*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/h3/a")]
        public IWebElement NewTab_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_NewTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[3]/a")]
        public IWebElement CommentsLink_NewTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/div/div/p")]
        public IWebElement ShortDescription_NewTab { get; set; }

        /*Missing image*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/figure/a/img")]
        public IWebElement Image_NewTab { get; set; }









    }
}

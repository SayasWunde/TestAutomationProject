

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class DragAndDrop_In_Action_Folder
    {

        public DragAndDrop_In_Action_Folder(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-202\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-202\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-202\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-202\"]/header/p/span[3]/a")]
        public IWebElement ActionLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-202\"]/header/p/span[4]/a")]
        public IWebElement CommentLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-202\"]/div/p")]
        public IWebElement ShortDescription { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#post-202 > div > p > a")]
        public IWebElement LinkToDraganddropPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div/a/p")]
        public IWebElement PreviousButtonToNewTab { get; set; }



    }
}

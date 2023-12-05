
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class ActionFolder
    {
        public ActionFolder(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/header/h1")]
        public IWebElement Title { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article/div/header/h3/a")]
        public IWebElement DragAndDropPost { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_DragAndDrop { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article/div/header/div/span[3]/a")]
        public IWebElement CommentsLink_DragAndDrop { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article/div/div/div/p")]
        public IWebElement ShortDescription_DragAndDrop { get; set; }
        /*Missing image open bug*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article/figure/a/img")]
        public IWebElement Image_DragAndDrop { get; set; }

    }
}

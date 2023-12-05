
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class NewTab_Post
    {
        public NewTab_Post(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-182\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-182\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-182\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-182\"]/header/p/span[3]/a")]
        public IWebElement Tab_and_Window_Folder_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-182\"]/header/p/span[4]/a")]
        public IWebElement CommentsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-182\"]/div/p[1]/a[1]")]
        public IWebElement TabLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-182\"]/div/p[1]/a[2]")]
        public IWebElement WindowLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[2]/a/p")]
        public IWebElement NextButton_TO_DragAndDrop { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[1]/a/p")]
        public IWebElement PreviosButton_TO_AlertBox_Post { get; set; }

    }
}

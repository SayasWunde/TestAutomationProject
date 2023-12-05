using OpenQA.Selenium;
using SeleniumExtras.PageObjects;



namespace WebTestingProject.UI_Elements
{
    public class Tabs_and_Windows_Folder
    {
        public Tabs_and_Windows_Folder(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
       
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/header/h1")]
        public IWebElement Title { get; set; }
       

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article/div/header/h3/a")]
        public IWebElement NewTabPost { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article/div/header/div/span[2]/a")]
        public IWebElement TodorVachevLink_NewTab  { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article/div/header/div/span[3]/a")]
        public IWebElement CommentsLink_NewTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article/div/div/div/p")]
        public IWebElement ShortDescription_NewTabPost { get; set; }
        /*Missing image open bug*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article/figure/a/img")]
        public IWebElement Image_NewTabPost { get; set; }

       
    }
}

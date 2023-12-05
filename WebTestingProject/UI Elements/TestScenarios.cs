

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    class TestScenarios
    {
        public TestScenarios(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/header/h1")]
        public IWebElement Title { get; set; }
        
        /*LoginForm*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/h3/a")]
        public IWebElement LogInForm_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[2]/a")]
        public IWebElement LogInForm_TodorVachev_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[3]/a")]
        public IWebElement LogInForm_Comment_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/div/div/p/a")]
        public IWebElement LogInForm_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/div/div/p")]
        public IWebElement LogInForm_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/figure/a/img")]
        public IWebElement LogInForm_Image { get; set; }


        /*RegisterForm*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/h3/a")]
        public IWebElement RegisterForm_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[2]/a")]
        public IWebElement RegisterForm_TodorVachev_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[3]/a")]
        public IWebElement RegisterForm_Comment_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/div/div/p/a")]
        public IWebElement RegisterForm_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/div/div/p")]
        public IWebElement RegisterForm_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/figure/a/img")]
        public IWebElement RegisterForm_Image { get; set; }

    }
}

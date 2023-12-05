
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class Selectors
    {
        public Selectors(IWebDriver driver) /*constructor for this class*/
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/header/h1")]
        public IWebElement Title { get; set; }

        /*Name*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/h3/a")]
        public IWebElement Name_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[2]/a")]
        public IWebElement Name_TodorVachev_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[3]/a")]
        public IWebElement Name_Comments_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/div/div/p/a")]
        public IWebElement Name_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/div/div/p")]
        public IWebElement Name_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/figure/a/img")]
        public IWebElement Name_Image { get; set; }


        /*ID*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/h3/a")]
        public IWebElement ID_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[2]/a")]
        public IWebElement ID_TodorVachev_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[3]/a")]
        public IWebElement ID_Comments_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/div/div/p/a")]
        public IWebElement ID_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/div/div/p")]
        public IWebElement ID_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/figure/a/img")]
        public IWebElement ID_Image { get; set; }


        /*Xpath*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/h3/a")]
        public IWebElement Xpath_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/div/span[2]/a")]
        public IWebElement Xpath_TodorVachev_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/div/span[3]/a")]
        public IWebElement Xpath_Comments_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/div/div/p/a")]
        public IWebElement Xpath_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/div/div/p")]
        public IWebElement Xpath_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/figure/a/img")]
        public IWebElement Xpath_Image { get; set; }


        /*CssPath*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/h3/a")]
        public IWebElement CssPath_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/div/span[2]/a")]
        public IWebElement CssPath_TodorVachev_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/div/span[3]/a")]
        public IWebElement CssPath_Comments_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/div/div/p/a")]
        public IWebElement CssPath_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/div/div/p")]
        public IWebElement CssPath_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/figure/a/img")]
        public IWebElement CssPath_Image { get; set; }


        /*ClassName*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/h3/a")]
        public IWebElement ClassName_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/div/span[2]/a")]
        public IWebElement ClassName_TodorVachev_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/div/span[3]/a")]
        public IWebElement ClassName_Comments_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/div/div/p/a")]
        public IWebElement ClassName_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/div/div/p")]
        public IWebElement ClassName_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/figure/a/img")]
        public IWebElement ClassName_Image { get; set; }

    }


}

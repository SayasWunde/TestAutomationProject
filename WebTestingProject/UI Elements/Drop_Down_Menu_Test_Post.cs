
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class Drop_Down_Menu_Test_Post
    {
        public Drop_Down_Menu_Test_Post(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/header/p/span[3]/a")]
        public IWebElement SpecialElementsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/header/p/span[4]/a")]
        public IWebElement CommentLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/figure/img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/p[1]")]
        public IWebElement ShortDiscriptionSection_1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/p[2]")]
        public IWebElement ShortDiscriptionSection_2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/p[3]")]
        public IWebElement ShortDiscriptionSection_3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/h3")]
        public IWebElement DropDownMenuHeadline { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/p[4]/select")]
        public IWebElement DropDownMenuField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/p[4]/select/option[1]")]
        public IWebElement DropDownOption_Volvo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/p[4]/select/option[2]")]
        public IWebElement DropDownOption_Saab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/p[4]/select/option[3]")]
        public IWebElement DropDownOption_Mercedes { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/p[4]/select/option[4]")]
        public IWebElement DropDownOption_Audi { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/h6")]
        public IWebElement TextToExampleLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-6\"]/div/h6/a")]
        public IWebElement LinkToExample { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div/a/span")]
        public IWebElement NextButtonTo_RadioButtonTest { get; set; }
    }
}

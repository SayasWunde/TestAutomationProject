
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    class SpecialElements
    {
        public SpecialElements(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/header/h1")]
        public IWebElement Title { get; set; }


        /*AlertBox*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/h3/a")]
        public IWebElement AlertBox_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[2]/a")]
        public IWebElement AlertBox_TodorVachev_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/header/div/span[3]/a")]
        public IWebElement AlertBox_Comment_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/div/div/p/a")]
        public IWebElement AlertBox_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div/div/div/p")]
        public IWebElement AlertBox_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/figure/a/img")]
        public IWebElement AlertBox_Image { get; set; }


        /*Text Input Field*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/h3/a")]
        public IWebElement TextInputField_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[2]/a")]
        public IWebElement TextInputField_TodorVachev_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/div/span[3]/a")]
        public IWebElement TextInputField_Comment_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/div/div/p/a")]
        public IWebElement TextInputField_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/div/div/p")]
        public IWebElement TextInputField_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/figure/a/img")]
        public IWebElement TextInputField_Image { get; set; }


        /*Check Button Test*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/h3/a")]
        public IWebElement CheckButtonTest_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/div/span[2]/a")]
        public IWebElement CheckButtonTest_TodorVachev_Link { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/div/span[3]/a")]
        public IWebElement CheckButtonTest_Comment_Link { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/div/div/p/a")]
        public IWebElement CheckButtonTest_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/div/div/p")]
        public IWebElement CheckButtonTest_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/figure/a/img")]
        public IWebElement CheckButtonTest_Image { get; set; }



        /*Radio Button Test*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/h3/a")]
        public IWebElement RadioButtonTest_Post { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/div/span[2]/a")]
        public IWebElement RadioButtonTest_TodorVachev_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/header/div/span[3]/a")]
        public IWebElement RadioButtonTest_Comment_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/div/div/p/a")]
        public IWebElement RadioButtonTest_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div/div/div/p")]
        public IWebElement RadioButtonTest_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/figure/a/img")]
        public IWebElement RadioButtonTest_Image { get; set; }


        /*DropDwonMenuTest_Post*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/h3/a")]
        public IWebElement DropDwonMenuTest_Post { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/div/span[2]/a")]
        public IWebElement DropDwonMenuTest_TodorVachev_Link { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/header/div/span[3]/a")]
        public IWebElement DropDwonMenuTest_Comment_Link { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/div/div/p/a")]
        public IWebElement DropDwonMenuTest_ReadMore_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div/div/div/p")]
        public IWebElement DropDwonMenuTest_ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/figure/a/img")]
        public IWebElement DropDwonMenuTest_Image { get; set; }
        
    }




}

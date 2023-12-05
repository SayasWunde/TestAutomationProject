using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTestingProject.UI_Elements
{
    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"mh-mobile\"]/div/header/div[1]/div/div/div/div/a/h1")]
        public IWebElement HeadlineAboveMenue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"mh-mobile\"]/div/header/div[1]/div/div/div/div/a/h2")]
        public IWebElement SubHeadlineAboveMenu { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-17\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-17\"]/div/p[1]/a/img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-17\"]/div/p[2]")]
        public IWebElement paragraph_1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-17\"]/div/p[3]")]
        public IWebElement paragraph_2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-17\"]/div/p[4]")]
        public IWebElement paragraph_3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-17\"]/div/p[5]")]
        public IWebElement paragraph_4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-17\"]/div/p[6]")]
        public IWebElement paragraph_5 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-17\"]/div/p[7]")]
        public IWebElement paragraph_6 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-17\"]/div/p[8]/code")]
        public IWebElement paragraph_7 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-17\"]/div/p[9]")]
        public IWebElement paragraph_8 { get; set; }

    }
}

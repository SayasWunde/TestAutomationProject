using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class DragAndDrop_Page
    {

        public DragAndDrop_Page(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/center/h2")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.Id, Using = "Drag1")]
        public IWebElement Drag_1 { get; set; }

        [FindsBy(How = How.Id, Using = "Drag2")]
        public IWebElement Drag_2 { get; set; }

        [FindsBy(How = How.Id, Using = "Drag3")]
        public IWebElement Drag_3 { get; set; }

        [FindsBy(How = How.Id, Using = "Drag4")]
        public IWebElement Drag_4 { get; set; }

        [FindsBy(How = How.Id, Using = "Drag5")]
        public IWebElement Drag_5 { get; set; }






    }
}

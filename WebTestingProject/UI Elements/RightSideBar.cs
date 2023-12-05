
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class RightSideBar
    {
        public RightSideBar(IWebDriver driver) /*constructor for this class*/
        {
            PageFactory.InitElements(driver, this);
        }

        /*search text field*/
        [FindsBy(How = How.CssSelector, Using = "#search-2 > form > label > input")]
        public IWebElement SearchField { get; set; }


        /*Recent posts section*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"recent-posts-2\"]/h4/span")]
        public IWebElement RecentPosts_Title { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(1) > a")]
        public IWebElement RecentPosts_DragAndDrop { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(2) > a")]
        public IWebElement RecentPosts_NewTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(3) > a")]
        public IWebElement RecentPosts_AlertBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(4) > a")]
        public IWebElement RecentPosts_Name { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(5) > a")]
        public IWebElement RecentPosts_Id { get; set; }

        /*Categories*/


        [FindsBy(How = How.XPath, Using = "//*[@id=\"categories-2\"]/h4/span")]
        public IWebElement Categories_Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"cat\"]")]
        public IWebElement Categories_DropDouwnMenu_Field { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(1)")]
        public IWebElement Categories_DropDouwnMenu_Option0_Default{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(2)")]
        public IWebElement Categories_DropDouwnMenu_Option1_Action { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(3)")]
        public IWebElement Categories_DropDouwnMenu_Option2_Selectors { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(4)")]
        public IWebElement Categories_DropDouwnMenu_Option3_SpecialElements { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(5)")]
        public IWebElement Categories_DropDouwnMenu_Option4_TabAndWindow{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(6)")]
        public IWebElement Categories_DropDouwnMenu_Option5_TestCase{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(7)")]
        public IWebElement Categories_DropDouwnMenu_Option6_TestScenarios{ get; set; }
        /*Meta section*/
        [FindsBy(How = How.XPath, Using = "//*[@id=\"meta-2\"]/h4/span")]
        public IWebElement Meta_Title { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(1) > a")]
        public IWebElement Meta_Login { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(2) > a")]
        public IWebElement Meta_EntriesFeed { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(3) > a")]
        public IWebElement Meta_CommentsFeed { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(3) > a")]
        public IWebElement Meta_WordPressOrg { get; set; }

    }
}

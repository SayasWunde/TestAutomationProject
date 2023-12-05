using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;
using WebTestingProject.UI_Elements;
using System.Threading;

namespace WebTestingProject.Scenarios
{
    /*[Parallelizable] /*Will make the test run parallele*/
    [Parallelizable(ParallelScope.None)] // Will make the test run seperetly*/
    public class DragAndDrop
    {
        string lightGreenHoverdPressed = "rgba(144, 238, 144, 1)";
        string HoverdNOTPressed = "rgba(255, 222, 173, 1)";
        public IWebDriver Driver { get; set; }
        [OneTimeSetUp] /*One time set up -- Exuted one time befor all the test below it */
        public void Initialize()
        {
            Driver = Action.InitializeDriver();
            NavigateTo.DragAndDropPage(Driver);        
        }
        [Test]
        public void BeforeHoveringTestColorDontChange()
        {
            DragAndDrop_Page ddp = new DragAndDrop_Page(Driver);
            Assert.That(ddp.Drag_1.GetCssValue("background-color"),Is.EqualTo( HoverdNOTPressed));
            Assert.That(ddp.Drag_2.GetCssValue("background-color"), Is.EqualTo(HoverdNOTPressed));
            Assert.That(ddp.Drag_3.GetCssValue("background-color"), Is.EqualTo(HoverdNOTPressed));
            Assert.That(ddp.Drag_4.GetCssValue("background-color"), Is.EqualTo(HoverdNOTPressed));
            Assert.That(ddp.Drag_5.GetCssValue("background-color"), Is.EqualTo(HoverdNOTPressed));
        }
        [Test]
        public void ElementBeingHoveredColoreIsChanging()
        {
            Actions actions = new Actions(Driver);
            DragAndDrop_Page ddp = new DragAndDrop_Page(Driver);
            Action.HoverOnElement(actions, ddp.Drag_1);
            Assert.That(ddp.Drag_1.GetCssValue("background-color"), Is.EqualTo(lightGreenHoverdPressed));
            Action.HoverOnElement(actions, ddp.Drag_2);
            Assert.That(ddp.Drag_2.GetCssValue("background-color"), Is.EqualTo(lightGreenHoverdPressed));
            Action.HoverOnElement(actions, ddp.Drag_3);
            Assert.That(ddp.Drag_3.GetCssValue("background-color"), Is.EqualTo(lightGreenHoverdPressed));
            Action.HoverOnElement(actions, ddp.Drag_4);
            Assert.That(ddp.Drag_4.GetCssValue("background-color"), Is.EqualTo(lightGreenHoverdPressed));
            Action.HoverOnElement(actions, ddp.Drag_5);
            Assert.That(ddp.Drag_5.GetCssValue("background-color"), Is.EqualTo(lightGreenHoverdPressed));  
        }
        [Test]
        public void CurrentLocationBeforSwapingTest()
        {
            DragAndDrop_Page ddp = new DragAndDrop_Page(Driver);
            /*Drag1 - Location */
            Assert.That(ddp.Drag_1.Location.X, Is.EqualTo(436),"If this test failed its because your screen size is different then the screen that it was tested on");
            Assert.That(ddp.Drag_1.Location.Y, Is.EqualTo(55), "If this test failed its because your screen size is different then the screen that it was tested on");
            /*Drag2 - Location */
            Assert.That(ddp.Drag_2.Location.X, Is.EqualTo(436), "If this test failed its because your screen size is different then the screen that it was tested on");
            Assert.That(ddp.Drag_2.Location.Y, Is.EqualTo(95), "If this test failed its because your screen size is different then the screen that it was tested on");
            /*Drag3 - Location */
            Assert.That(ddp.Drag_3.Location.X, Is.EqualTo(436), "If this test failed its because your screen size is different then the screen that it was tested on");
            Assert.That(ddp.Drag_3.Location.Y, Is.EqualTo(135), "If this test failed its because your screen size is different then the screen that it was tested on");
            /*Drag4 - Location */
            Assert.That(ddp.Drag_4.Location.X, Is.EqualTo(436), "If this test failed its because your screen size is different then the screen that it was tested on");
            Assert.That(ddp.Drag_4.Location.Y, Is.EqualTo(175), "If this test failed its because your screen size is different then the screen that it was tested on");
            /*Drag5 - Location */
            Assert.That(ddp.Drag_5.Location.X, Is.EqualTo(436), "If this test failed its because your screen size is different then the screen that it was tested on");
            Assert.That(ddp.Drag_5.Location.Y, Is.EqualTo(215), "If this test failed its because your screen size is different then the screen that it was tested on");
        }
        [Test]
        public void LocationAfterSwapTest()
        {
            DragAndDrop_Page ddp = new DragAndDrop_Page(Driver);
            Action.MoveElement(new Actions(Driver), ddp.Drag_1, ddp.Drag_5);
            Thread.Sleep(1000);
            Action.MoveElement(new Actions(Driver), ddp.Drag_2, ddp.Drag_5);
            Thread.Sleep(1000);
            Action.MoveElement(new Actions(Driver), ddp.Drag_3, ddp.Drag_5);
            Thread.Sleep(1000);
            Action.MoveElement(new Actions(Driver), ddp.Drag_4, ddp.Drag_5);
            /*Checking location after swaping*/
            /*Drag5 - Location */
            Assert.That(ddp.Drag_5.Location.X, Is.EqualTo(436), "If this test failed its because your screen size is different then the screen that it was tested on");
            Assert.That(ddp.Drag_5.Location.Y, Is.EqualTo(55), "If this test failed its because your screen size is different then the screen that it was tested on");
            /*Drag3 - Location */
            Assert.That(ddp.Drag_3.Location.X, Is.EqualTo(436), "If this test failed its because your screen size is different then the screen that it was tested on");
            Assert.That(ddp.Drag_3.Location.Y, Is.EqualTo(135), "If this test failed its because your screen size is different then the screen that it was tested on");
            /*Drag2 - Location */
            Assert.That(ddp.Drag_2.Location.X, Is.EqualTo(436), "If this test failed its because your screen size is different then the screen that it was tested on");
            Assert.That(ddp.Drag_2.Location.Y, Is.EqualTo(175), "If this test failed its because your screen size is different then the screen that it was tested on");
            /*Drag1 - Location */
            Assert.That(ddp.Drag_1.Location.X, Is.EqualTo(436), "If this test failed its because your screen size is different then the screen that it was tested on");
            Assert.That(ddp.Drag_1.Location.Y, Is.EqualTo(215), "If this test failed its because your screen size is different then the screen that it was tested on");
            /*Drag4 must be in place*/
        }
        [OneTimeTearDown]/*In the end */
        public void CleanUp()
        {
            Driver.Quit();
        }




    }
}

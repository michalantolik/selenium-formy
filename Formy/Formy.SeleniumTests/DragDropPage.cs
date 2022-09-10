using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Formy.SeleniumTests
{
    [TestClass]
    public class DragDropPage
    {
        private readonly string url = "https://formy-project.herokuapp.com/dragdrop";

        [TestMethod]
        public void DragAndDropImage()
        {
            using(var driver = new ChromeDriver())
            {
                // ARRANGE
                driver.Navigate().GoToUrl(url);

                // ACT
                var image = driver.FindElement(By.Id("image"));
                var box = driver.FindElement(By.Id("box"));

                Actions actions = new Actions(driver);
                actions.DragAndDrop(image, box).Build().Perform();

                // NOTHING TO ASSERT
            }
        }
    }
}

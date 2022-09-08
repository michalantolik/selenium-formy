using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Formy.SeleniumTests
{
    [TestClass]
    public class ScrollPage
    {
        private readonly string url = "https://formy-project.herokuapp.com/scroll";

        [TestMethod]
        public void MoveToElement()
        {
            using(var driver = new ChromeDriver())
            {
                // ACT
                Actions actions = new Actions(driver);
                driver.Navigate().GoToUrl(this.url);

                var nameInput = driver.FindElement(By.Id("name"));
                actions.MoveToElement(nameInput);
                nameInput.SendKeys("Jason Huggins");

                var dateInput = driver.FindElement(By.Id("date"));
                actions.MoveToElement(dateInput);
                dateInput.SendKeys("01/01/2022");

                // NOTHING TO ASSERT
            }
        }
    }
}

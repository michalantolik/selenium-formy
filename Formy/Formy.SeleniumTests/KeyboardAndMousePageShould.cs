using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Formy.SeleniumTests
{
    [TestClass]
    public class KeyboardAndMousePageShould
    {
        private readonly string url = "https://formy-project.herokuapp.com/keypress";

        [TestMethod]
        public void Open()
        {
            using(var driver = new ChromeDriver())
            {
                // ACT
                driver.Navigate().GoToUrl(this.url);

                // ASSERT
                Assert.AreEqual(this.url, driver.Url);
                Assert.AreEqual("Formy", driver.Title);
            }
        }

        [TestMethod]
        public void EnterName()
        {
            using(var driver = new ChromeDriver())
            {
                // ARRANGE
                var name = "Jason Huggins";
                driver.Navigate().GoToUrl(this.url);

                // ACT
                var nameInput = driver.FindElement(By.Id("name"));
                nameInput.SendKeys(name);

                // NOTHING TO ASSERT
            }
        }

        [TestMethod]
        public void ClickButton()
        {
            using (var driver = new ChromeDriver())
            {
                // ARRANGE
                driver.Navigate().GoToUrl(this.url);

                // ACT
                var button = driver.FindElement(By.Id("button"));
                button.Click();

                // NOTHING TO ASSERT
            }
        }
    }
}

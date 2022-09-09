using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Formy.SeleniumTests
{
    [TestClass]
    public class SwitchPage
    {
        private readonly string url = "https://formy-project.herokuapp.com/switch-window";

        [TestMethod]
        public void SwitchToWindow()
        {
            using(var driver = new ChromeDriver())
            {
                // ARRANGE
                driver.Navigate().GoToUrl(url);
                var newTabButton = driver.FindElement(By.Id("new-tab-button"));
                newTabButton.Click();

                // ACT
                var originalHandle = driver.CurrentWindowHandle;
                foreach (var handle in driver.WindowHandles)
                {
                    driver.SwitchTo().Window(handle);
                }
                driver.SwitchTo().Window(originalHandle);

                // NOTHING TO ASSERT
            }
        }

        [TestMethod]
        public void SwitchToAlert()
        {
            using (var driver = new ChromeDriver())
            {
                // ARRANGE
                driver.Navigate().GoToUrl(url);
                var alertButton = driver.FindElement(By.Id("alert-button"));
                alertButton.Click();

                // ACT
                var alert = driver.SwitchTo().Alert();
                alert.Accept();

                // NOTHING TO ASSERT
            }
        }
    }
}

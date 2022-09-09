using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Formy.SeleniumTests
{
    [TestClass]
    public class ModalPage
    {
        private readonly string url = "https://formy-project.herokuapp.com/modal";

        [TestMethod]
        public void CloseModal()
        {
            using(var driver = new ChromeDriver())
            {
                // ARRANGE
                driver.Navigate().GoToUrl(url);
                var modalButton = driver.FindElement(By.Id("modal-button"));
                modalButton.Click();

                // ACT
                var closeButton = driver.FindElement(By.Id("close-button"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", closeButton);

                // NOTHING TO ASSERT
            }
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Formy.SeleniumTests
{
    [TestClass]
    public class RadiobuttonsPage
    {
        private readonly string url = "https://formy-project.herokuapp.com/radiobutton";

        [TestMethod]
        public void ClickThroughRadiobuttons()
        {
            using(var driver = new ChromeDriver())
            {
                // ARRANGE
                driver.Navigate().GoToUrl(url);

                // ACT
                var radiobutton1 = driver.FindElement(
                    By.Id("radio-button-1"));
                radiobutton1.Click();

                var radiobutton2 = driver.FindElement(
                    By.CssSelector("input[value='option2']"));
                radiobutton2.Click();

                var radiobutton3 = driver.FindElement(
                    By.XPath("/html/body/div/div[3]/input"));
                radiobutton3.Click();

                // NOTHING TO ASSERT
            }
        }
    }
}

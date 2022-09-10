using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Formy.SeleniumTests
{
    [TestClass]
    public class DatepickerPage
    {
        private readonly string url = "https://formy-project.herokuapp.com/datepicker";

        [TestMethod]
        public void SetDate()
        {
            using(var driver = new ChromeDriver())
            {
                // ARRANGE
                driver.Navigate().GoToUrl(url);

                // ACT
                var dateField = driver.FindElement(By.Id("datepicker"));
                dateField.SendKeys("12/03/2020");
                dateField.SendKeys(Keys.Return);

                // NOTHING TO ASSERT
            }
        }
    }
}

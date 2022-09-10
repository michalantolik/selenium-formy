using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Formy.SeleniumTests
{
    [TestClass]
    public class DropdownPage
    {
        private readonly string url = "https://formy-project.herokuapp.com/dropdown";

        [TestMethod]
        public void SelectDropdownItem()
        {
            using(var driver = new ChromeDriver())
            {
                // ARRANGE
                driver.Navigate().GoToUrl(url);

                // ACT
                var dropDownMenu = driver.FindElement(By.Id("dropdownMenuButton"));
                dropDownMenu.Click();

                var autocompleteItem = driver.FindElement(By.Id("autocomplete"));
                autocompleteItem.Click();

                // NOTHING TO ASSERT
            }
        }
    }
}

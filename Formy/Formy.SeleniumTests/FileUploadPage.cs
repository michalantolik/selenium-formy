using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Formy.SeleniumTests
{
    [TestClass]
    public class FileUploadPage
    {
        private readonly string url = "https://formy-project.herokuapp.com/fileupload";

        [TestMethod]
        public void SelectDropdownItem()
        {
            using(var driver = new ChromeDriver())
            {
                // ARRANGE
                driver.Navigate().GoToUrl(url);

                // ACT
                var fileUploadField = driver.FindElement(By.Id("file-upload-field"));
                fileUploadField.SendKeys("file-to-upload.png");

                // NOTHING TO ASSERT
            }
        }
    }
}

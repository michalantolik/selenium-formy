using OpenQA.Selenium.Chrome;

namespace Formy.SeleniumTests
{
    [TestClass]
    public class Homepage
    {
        private readonly string url = "https://formy-project.herokuapp.com/";

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
    }
}
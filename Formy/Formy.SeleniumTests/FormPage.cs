using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Formy.SeleniumTests
{
    [TestClass]
    public class FormPage
    {
        private readonly string url = "https://formy-project.herokuapp.com/form";

        [TestMethod]
        public void FillAndSubmit()
        {
            using(var driver = new ChromeDriver())
            {
                // ARRANGE
                driver.Navigate().GoToUrl(url);
                driver.FindElement(By.Id("first-name")).SendKeys("Jason");
                driver.FindElement(By.Id("last-name")).SendKeys("Huggins");
                driver.FindElement(By.Id("job-title")).SendKeys("Founder & CEO");
                driver.FindElement(By.Id("radio-button-2")).Click();
                driver.FindElement(By.Id("checkbox-1")).Click();
                driver.FindElement(By.CssSelector("option[value='4'")).Click();
                
                var datepicker = driver.FindElement(By.Id("datepicker"));
                datepicker.SendKeys("05/28/2022");
                datepicker.SendKeys(Keys.Return);

                driver.FindElement(By.CssSelector(".btn.btn-lg.btn-primary")).Click();

                // ASSERT
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(drv => drv.FindElement(By.ClassName("alert")).Displayed);

                var alert = driver.FindElement(By.ClassName("alert"));
                Assert.AreEqual("The form was successfully submitted!", alert.Text);
            }
        }
    }
}

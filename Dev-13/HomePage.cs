using OpenQA.Selenium;

namespace Dev_13
{
    class HomePage
    {
        IWebDriver driver;
        By homePage = By.XPath("//*[contains(text(),'Входящие')]");
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void FindNeedElement()
        {
            driver.FindElement(homePage);
        }
    }
}

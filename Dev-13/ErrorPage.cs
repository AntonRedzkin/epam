using OpenQA.Selenium;

namespace Dev_13
{
    class ErrorPage
    {
        IWebDriver driver;
        By errorPage = By.XPath("//*[contains(text(),'Вход')]");
        public ErrorPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FindNeedElement()
        {
            driver.FindElement(errorPage);
        }
    }
}

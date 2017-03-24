using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Dev_13
{
    [TestClass]
    public class TestMailRu
    {
        IWebDriver driver;
        HomePage homePage;
        AuthorizationPage autoPage;
        ErrorPage errorPage;
        string baseURL = "https://mail.ru";
        string password = "23.03.2017";
        string user = "tat-de13@mail.ru";

        [TestMethod]
        public void TestValidInput_Chrome()
        {
            using (driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(baseURL);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, password);
                homePage = new HomePage(driver);
                homePage.FindNeedElement();
            }
        }

        [TestMethod]
        public void TestValidInput_Firefox()
        {
            using (driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, password);
                homePage = new HomePage(driver);
                homePage.FindNeedElement();
            }

        }

        [TestMethod]
        public void TestValidInput_IE()
        {
            using (driver = new InternetExplorerDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, password);
                homePage = new HomePage(driver);
                homePage.FindNeedElement();
            }
        }

        // Empty input password
        [TestMethod]
        public void TestEmptyInputPassword_Chrome()
        {
            using (driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, "");
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void TestEmptyInputPassword_Firefox()
        {
            using (driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, "");
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void TestEmptyInput_Chrome()
        {
            using (driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm("", "");
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void TestEmptyInput_Firefox()
        {
            using (driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm("", "");
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void TestErrorInputPassword_Chrome()
        {
            using (driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, "23.03.2016");
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void TestErrorInputPassword_Firefox()
        {
            using (driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, "23.03.2016");
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void TestNotValidLogin_Chrome()
        {
            using (driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm("123", password);
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void TestNotvalidLogin_Firefox()
        {
            using (driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm("123", password);
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }
    }
}

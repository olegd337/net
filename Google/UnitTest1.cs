using Allure.Commons;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Google
{
    [TestFixture(Author = "unickq", Description = "Examples")]
   // [AllureReport]
    //[AllureLink("https://github.com/allure-framework/allure-csharp")]
    public class Tests : AllureReport
    {
        private IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [Test]
        //[AllureTag("NUnit", "Debug")]
        //[AllureIssue("GitHub#1", "https://github.com/allure-framework/allure-csharp")]
        //[AllureSeverity(SeverityLevel.critical)]
        //[AllureFeature("Core")]
        public void Test1()
        {
            _webDriver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(_webDriver.Title.Contains("Google"));
        }

        [Test]
        //[AllureTag("NUnit", "Debug")]
        //[AllureIssue("GitHub#1", "https://github.com/allure-framework/allure-csharp")]
        //[AllureSeverity(SeverityLevel.critical)]
        //[AllureFeature("Core")]
        public void Test123()
        {
            _webDriver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(_webDriver.Title.Contains("Google1111"));
        }
    }
}
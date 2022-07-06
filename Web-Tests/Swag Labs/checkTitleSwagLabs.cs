using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace Web_Tests.Swag_Labs
{
    [TestFixture]
    public class checkTitleSwagLabs
    {
        private IWebDriver _webDriver;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }

        [Test]
        public void checkTitleSwagLabsChromeTest()
        {
            _webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Assert.That(_webDriver.Title.Contains("Swag Labs"));
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

    }
}

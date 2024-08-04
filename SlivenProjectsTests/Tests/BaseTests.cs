using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class BaseTests
    {
        protected IWebDriver driver;
        ChromeOptions options = new ChromeOptions();
        BasePage basePage;

        [SetUp]
        public void Setup()
        {

            options.AddArgument("headless");
            options.AddArgument("remote-debugging-port=9222");
            options.AddArgument("disable-gpu");
            options.AddArgument("no-sandbox");
            options.AddArgument("disable-dev-shm-usage");
            options.AddArgument("windows-size=1920x1080");
            options.AddArgument("disable-extensions");
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArgument("--disable-search-engine-choice-screen");

            driver = new ChromeDriver(options);

            basePage = new BasePage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

    }
}

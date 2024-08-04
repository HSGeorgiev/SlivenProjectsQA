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
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArgument("disable-search-engine-choice-screen");
            options.AddArgument("window-size=1920,1080");
            options.AddArgument("disable-extensions");
            options.AddArgument("disable-dev-shm-usage");
            options.AddArgument("no-sandbox");

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

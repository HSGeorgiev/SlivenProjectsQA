﻿using OpenQA.Selenium;

namespace SlivenProjectsTests.Pages
{
    internal class PreEUFundsPage : BasePage
    {
        // Descript the element and logic on the Pre EU Funds page,
        // excluding base elements, common for all pages.
        public PreEUFundsPage(IWebDriver driver) : base(driver)
        {
        }

        public new string pageUrl => BASE_URL + "/index.php?option=com_sobi2&catid=9&Itemid=53";
    }
}

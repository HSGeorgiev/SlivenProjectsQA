﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Pages
{
    // Descript the element and logic on the Structural Funds page,
    // excluding base elements, common for all pages.
    internal class StructuralFundsPage : BasePage
    {
        public StructuralFundsPage(IWebDriver driver) : base(driver)
        {
        }
    }
}

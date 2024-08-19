using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Pages
{
    internal class PreEUFundsPage : BasePage
    {
        // Descript the element and logic on the Pre EU Funds page,
        // excluding base elements, common for all pages.
        public PreEUFundsPage(IWebDriver driver) : base(driver)
        {
        }

        public string pageUrl => BASE_URL + "/index.php?option=com_sobi2&catid=9&Itemid=53";
    }
}

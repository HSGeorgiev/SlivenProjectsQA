using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Pages
{
    internal class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        public By registerLink => By.XPath("//td[@id='sobi2HeaderComLink']/a");
        public By searchLink => By.XPath("//td[@id='sobi2HeaderComLink']/a");


    }
}

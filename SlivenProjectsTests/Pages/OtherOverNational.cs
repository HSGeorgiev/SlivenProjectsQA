using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Pages
{
    internal class OtherOverNational : BasePage
    {
        public OtherOverNational(IWebDriver driver) : base(driver)
        {
        }

        public new string pageUrl => BASE_URL + "/index.php?option=com_sobi2&catid=59&Itemid=53";

        public By categoriesNames => By.XPath("//p[@class='sobi2CatName']");
    }
}

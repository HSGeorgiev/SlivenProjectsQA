using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class HomePageTests : BaseTests
    {
       
        string subUrl = "/";


        [Test]
        public void TopMenu_LinkTexts_ShouldBeProper()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToTargetPage(subUrl);
            bool[] topMenuChecks = homePage.menuLinksTextsCheck(homePage.topMenuItems, homePage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {homePage.topMenuTexts[i]} " +
                    $"should be {homePage.topMenuTexts[i]}, but is not");
            }
        }
    }
}

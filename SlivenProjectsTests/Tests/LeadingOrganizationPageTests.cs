using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class LeadingOrganizationPageTests : BaseTests
    {
        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            LeadingOrganizationPage leadingOrganizationPage = new LeadingOrganizationPage(driver);
            leadingOrganizationPage.GoToTargetPage(leadingOrganizationPage.pageUrl);
            bool[] topMenuChecks = leadingOrganizationPage.menuLinksTextsCheck(leadingOrganizationPage.topMenuItems, leadingOrganizationPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {leadingOrganizationPage.topMenuTexts[i]} " +
                    $"should be {leadingOrganizationPage.topMenuTexts[i]}, but is not");
            }
        }




    }
}

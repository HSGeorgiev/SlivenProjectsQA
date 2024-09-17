using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class PartnerOrganizationPageTests : BaseTests
    {
        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var partnerOrganizationPage = new PartnerOrganizationPage(driver);
            partnerOrganizationPage.GoToTargetPage(partnerOrganizationPage.pageUrl);
            bool[] topMenuChecks = partnerOrganizationPage.menuLinksTextsCheck(partnerOrganizationPage.topMenuItems, partnerOrganizationPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {partnerOrganizationPage.topMenuTexts[i]} " +
                    $"should be {partnerOrganizationPage.topMenuTexts[i]}, but is not");
            }
        }
    }
}

using SlivenProjectsTests.Pages;

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

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var leadingOrganizationPage = new LeadingOrganizationPage(driver);
            leadingOrganizationPage.GoToTargetPage(leadingOrganizationPage.pageUrl);
            bool[] inRegisterMenuChecks = leadingOrganizationPage.menuLinksTextsCheck(leadingOrganizationPage.inRegisterMenuItems, leadingOrganizationPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {leadingOrganizationPage.inRegisterMenuTexts[i]} " +
                    $"should be {leadingOrganizationPage.inRegisterMenuTexts[i]}, but is not");
            }
        }


    }
}

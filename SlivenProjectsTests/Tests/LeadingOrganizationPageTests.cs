using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class LeadingOrganizationPageTests : BaseTests
    {

        [Test]
        public void FooterTextShouldBeCorect()
        {
            LeadingOrganizationPage leadingOrganizationPage = new LeadingOrganizationPage(driver);
            leadingOrganizationPage.GoToTargetPage(BASE_URL);
            string currentYear = DateTime.Now.Year.ToString();
            string footerTextActual = leadingOrganizationPage.GetText(leadingOrganizationPage.footerText);
            string footerTextExpected = $"Община Сливен, (с) 2008 - {currentYear}";
            //Console.WriteLine(footerTextActual);
            //Console.WriteLine(footerTextExpected);
            Assert.IsTrue(footerTextActual == footerTextExpected, "Footer text should be correct");
        }

        [Test]
        public void HeadingTextShouldBeCorect()
        {
            LeadingOrganizationPage leadingOrganizationPage = new LeadingOrganizationPage(driver);
            leadingOrganizationPage.GoToTargetPage(BASE_URL);

            string headingTextActual = leadingOrganizationPage.GetText(leadingOrganizationPage.pageHeading);
            string headingTextExpected = "Регистър за проекти - Община Сливен";
            //Console.WriteLine(headingTextActual);
            //Console.WriteLine(headingTextExpected);
            Assert.IsTrue(headingTextActual == headingTextExpected, "Footer text should be correct");
        }

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

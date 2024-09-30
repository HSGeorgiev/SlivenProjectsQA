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
        public void FooterTextShouldBeCorect()
        {
            var partnerOrganizationPage = new PartnerOrganizationPage(driver);
            partnerOrganizationPage.GoToTargetPage(BASE_URL);
            string currentYear = DateTime.Now.Year.ToString();
            string footerTextActual = partnerOrganizationPage.GetText(partnerOrganizationPage.footerText);
            string footerTextExpected = $"Община Сливен, (с) 2008 - {currentYear}";
            //Console.WriteLine(footerTextActual);
            //Console.WriteLine(footerTextExpected);
            Assert.IsTrue(footerTextActual == footerTextExpected, "Footer text should be correct");
        }



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

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var partnerOrganizationPage = new PartnerOrganizationPage(driver);
            partnerOrganizationPage.GoToTargetPage(partnerOrganizationPage.pageUrl);
            bool[] inRegisterMenuChecks = partnerOrganizationPage.menuLinksTextsCheck(partnerOrganizationPage.inRegisterMenuItems, partnerOrganizationPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {partnerOrganizationPage.inRegisterMenuTexts[i]} " +
                    $"should be {partnerOrganizationPage.inRegisterMenuTexts[i]}, but is not");
            }
        }
    }
}

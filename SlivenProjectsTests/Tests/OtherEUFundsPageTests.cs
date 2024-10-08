﻿using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class OtherEUFundsPageTests : BaseTests
    {

        [Test]
        public void FooterTextShouldBeCorect()
        {
            var otherEUFundsPage = new OtherEUInstrumentsPage(driver);
            otherEUFundsPage.GoToTargetPage(BASE_URL);
            string currentYear = DateTime.Now.Year.ToString();
            string footerTextActual = otherEUFundsPage.GetText(otherEUFundsPage.footerText);
            string footerTextExpected = $"Община Сливен, (с) 2008 - {currentYear}";
            //Console.WriteLine(footerTextActual);
            //Console.WriteLine(footerTextExpected);
            Assert.IsTrue(footerTextActual == footerTextExpected, "Footer text should be correct");
        }

        [Test]
        public void HeadingTextShouldBeCorect()
        {
            var otherEUFundsPage = new OtherEUInstrumentsPage(driver);
            otherEUFundsPage.GoToTargetPage(BASE_URL);

            string headingTextActual = otherEUFundsPage.GetText(otherEUFundsPage.pageHeading);
            string headingTextExpected = "Регистър за проекти - Община Сливен";
            //Console.WriteLine(headingTextActual);
            //Console.WriteLine(headingTextExpected);
            Assert.IsTrue(headingTextActual == headingTextExpected, "Footer text should be correct");
        }


        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var otherEUFundsPage = new OtherEUInstrumentsPage(driver);
            otherEUFundsPage.GoToTargetPage(otherEUFundsPage.pageUrl);
            bool[] topMenuChecks = otherEUFundsPage.menuLinksTextsCheck(otherEUFundsPage.topMenuItems, otherEUFundsPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"ByProjects Status menu item {otherEUFundsPage.topMenuTexts[i]} " +
                    $"should be {otherEUFundsPage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var otherEUFundsPage = new OtherEUInstrumentsPage(driver);
            otherEUFundsPage.GoToTargetPage(otherEUFundsPage.pageUrl);
            bool[] inRegisterMenuChecks = otherEUFundsPage.menuLinksTextsCheck(otherEUFundsPage.inRegisterMenuItems, otherEUFundsPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {otherEUFundsPage.inRegisterMenuTexts[i]} " +
                    $"should be {otherEUFundsPage.inRegisterMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByStatus_LinksTexts_ShouldBeProper()
        {
            var otherEUFundsPage = new OtherEUInstrumentsPage(driver);
            otherEUFundsPage.GoToTargetPage(otherEUFundsPage.pageUrl);
            bool[] byStatusMenuChecks = otherEUFundsPage.menuLinksTextsCheck(otherEUFundsPage.byStatusMenuItems, otherEUFundsPage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {
                Assert.IsTrue(byStatusMenuChecks[i], $"InRegister menu item {otherEUFundsPage.byStatusMenuTexts[i]} " +
                    $"should be {otherEUFundsPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void RoleOfSliven_LinksTexts_ShouldBeProper()
        {
            var otherEUFundsPage = new OtherEUInstrumentsPage(driver);
            otherEUFundsPage.GoToTargetPage(otherEUFundsPage.pageUrl);
            bool[] roleMenuChecks = otherEUFundsPage.menuLinksTextsCheck(otherEUFundsPage.roleOfSlivenMunMenuItems, otherEUFundsPage.roleOfSlivenMunMenuTexts);

            for (int i = 0; i < roleMenuChecks.Length; i++)
            {
                Assert.IsTrue(roleMenuChecks[i], $"By Role Of Sliven menu item {otherEUFundsPage.roleOfSlivenMunMenuTexts[i]} " +
                    $"should be {otherEUFundsPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByYearsMenu_LinksTexts_ShouldBeProper()
        {
            var otherEUFundsPage = new OtherEUInstrumentsPage(driver);
            otherEUFundsPage.GoToTargetPage(otherEUFundsPage.pageUrl);
            bool[] yearsMenuChecks = otherEUFundsPage.menuLinksTextsCheck(otherEUFundsPage.yearsMenuItems, otherEUFundsPage.yearsMenuTexts);

            for (int i = 0; i < yearsMenuChecks.Length; i++)
            {

                Assert.IsTrue(yearsMenuChecks[i], $"By year menu item {otherEUFundsPage.yearsMenuTexts[i]} " +
                    $"should be {otherEUFundsPage.yearsMenuTexts[i]}, but is not");
            }
        }
    }
}

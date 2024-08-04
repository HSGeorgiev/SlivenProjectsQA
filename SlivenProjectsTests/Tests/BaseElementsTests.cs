using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class BaseElementsTests : BaseTests
    {
        
        //Pages, accessible from the top menu
        [TestCase("Home","/")]
        [TestCase("Начало", "/index.php?option=com_sobi2&Itemid=87")]
        [TestCase("Структурни фондове на ЕС", "/index.php?option=com_sobi2&catid=9&Itemid=53")]
        [TestCase("Други инструменти на ЕС", "/index.php?option=com_sobi2&catid=8&Itemid=53")]
        [TestCase("Предприсъединителни фондове", "/index.php?option=com_sobi2&catid=7&Itemid=53")]
        [TestCase("Национални програми", "/index.php?option=com_sobi2&catid=6&Itemid=53")]
        [TestCase("Търсене", "/index.php?option=com_sobi2&sobi2Task=search&Itemid=53")]

        //Pages, accessible from the 'InTheRegister' menu
        [TestCase("Проекти", "/index.php?option=com_sobi2&Itemid=86")]

        public void TopMenu_LinksTexts_ShouldBeProper(string pageHeading, string subUrl)
        {
            BasePage basePage = new BasePage(driver);
            basePage.GoToTargetPage(subUrl);
            bool[] topMenuChecks = basePage.menuLinksTextsCheck(basePage.topMenuItems, basePage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"On the page {pageHeading}  'Top menu' item {basePage.topMenuTexts[i]} " +
                    $"should be {basePage.topMenuTexts[i]}, but is not");
            }
        }

    }
}

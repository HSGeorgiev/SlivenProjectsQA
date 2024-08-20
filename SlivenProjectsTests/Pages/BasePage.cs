﻿using OpenQA.Selenium;
using SlivenProjectsTests.Helpers;

namespace SlivenProjectsTests.Pages
{
    public class BasePage : DriverHelper
    {
 
        public BasePage(IWebDriver driver) : base(driver)
        {

        }

        // Go to current page

        public void GoToTargetPage(string pageUrl)
        {
            driver.Navigate().GoToUrl(pageUrl);
        }

        public string pageUrl => BASE_URL;

        // all six top-menu links
        public By topMenuItems = By.XPath("//ul[@class='art-hmenu']/li/a");
        // all eight 'In the Register' menu links
        public By inRegisterMenuItems = By.XPath("(//ul[@class='menu'])[1]//li");

        // texts on the all six top-menu links/tabs
        public string[] topMenuTexts = { "Начало", "Структурни фондове на ЕС", "Други инструменти на ЕС",
            "Предприсъединителни и-ти", "Национални програми", "Търсене" };
        // texts on the all eight 'In the Register' menu links
        public string[] inRegisterMenuTexts = { "Начало", "Проекти", "Търсене",
            "Структурни фондове на ЕС", "Други инструменти на ЕС",
            "Предприсъединителни фондове", "Национални програми и инструменти", 
            "Други наднационални инструменти"};

        public bool[] menuLinksTextsCheck(By by, string[] texts)

        // by => an By class menu element description - have to be a menu element
        // texts => an array of strings, containing menu's items' texts.
        // The number of the strings in texts[] should be equal to number of menu items
        // return array of bools, true if the element's text is equal to
        // the corresponding string in the argument array, else otherwise.
        // If number of elements doesn't fit length of texts array, fail the assert with message.
        
        {
            bool[] results = new bool[texts.Length];
            string[] menuElementsTexts = GetElementsTextArray(by);

            if (menuElementsTexts.Length == texts.Length)
            {
                for (int i = 0; i < texts.Length; i += 1)
                {
                    if (menuElementsTexts[i] == texts[i])
                    {
                        results[i] = true;
                    }
                    else
                    {
                        results[i] = false;
                    }
                }
            }
            else
            {
                Assert.Fail($"The number of top-menu items doesn't fit. " +
                    $"Must be {texts.Length}, but is {menuElementsTexts.Length}");
            }

            return results;
        }

        public bool[] menuLinksTargetsCheck(By by)

        // By by has to be an css selector of menu, containing li a
        // menuElementsTexts() returns an array of bools,
        // true if the element's text is equal to the text in the end of the 
        // pathway on the target page

        {
            string[] MenuElementsTexts = GetElementsTextArray(by);
            IWebElement[] menuElements = GetWebElementsArray(by);
            bool[] result = new bool[MenuElementsTexts.Length];
            Console.WriteLine(menuElements.Length);
            for (int i = 0; i < menuElements.Length; i += 1)
            {
                //Click(menuElements[i]);
                menuElements[i].Click();

                Console.WriteLine(MenuElementsTexts[i]);
                Console.WriteLine(menuElements[i].Text);

                string pathway = GetText(By.XPath("//*[@id=\"art-main\"]/div[1]/div[10]/div[5]/div/div[2]/div[1]/div[10]/div[1]/div[1]/span"));
                if (MenuElementsTexts[i] == pathway)
                {
                    result[i] = true;
                }
                else
                {
                    result[i] = false;
                }
                Console.WriteLine(result[i]);
                Console.WriteLine(pathway);
            }

            return result;
        }

        

    }
}

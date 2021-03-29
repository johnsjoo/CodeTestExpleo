using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTestExpleo
{
    public class FindLinks
    {
        public static void FindAllLinks()
        {
            //Not finished.
            var value = new ChromeDriver();
            value.Navigate().GoToUrl("https://www.google.se/");

            var result = value.FindElements(By.TagName("a"));

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].GetAttribute("href"));
            }
            value.Close();
        }

    }
}

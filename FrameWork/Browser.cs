using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FrameWork
{
    public static class Browser
    {
        public static IWebDriver driver;
        public static void Navigate()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(180));
            driver.Url = URL.url;

        }
        public static void PageLoadTimeout(double time)
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(time));
        }
    }
}

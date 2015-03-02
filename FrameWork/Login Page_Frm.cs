using System;
using System.Drawing;
using System.Drawing.Imaging;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Base_Driver;

namespace FrameWork
{
   
    public class Welcome
    {      
       
        public static void Click()
         {
             Browser.driver.FindElement(By.PartialLinkText("Welcome")).Click();
         }
        public static void AssertTitle(string title)
        {
            Assert.AreEqual(title, Browser.driver.Title);
        }
        public static void TakeScreenShot()
        {
            Screenshot ss = ((ITakesScreenshot)Browser.driver).GetScreenshot();
            ss.SaveAsFile("c:/desktop/Welcome_Page/", ImageFormat.Jpeg);
        }
        public static void Click_SideLinks()
        {
            Browser.driver.FindElement(By.PartialLinkText("step1")).Click();
            Browser.driver.FindElement(By.PartialLinkText("step2")).Click();
            Browser.driver.FindElement(By.PartialLinkText("step3")).Click();
            Browser.driver.FindElement(By.PartialLinkText("step4")).Click();
        }
    }
    
    public class Get_Started
    {
        public static void PageLoadTimeOut(double time)
        {
            Browser.PageLoadTimeout(time);
        }
        public static void Click()
        {
            Browser.driver.FindElement(By.PartialLinkText("Get Started")).Click();
        }
        public static void EnterAccountNo()
        {
            IWebElement account=Browser.driver.FindElement(By.Id("ContentPlaceHolder1_txtAcc"));
            account.SendKeys("1111122234");
            IWebElement confirm_account = Browser.driver.FindElement(By.Id("ContentPlaceHolder1_txtAccConfirm"));
            confirm_account.SendKeys("1111122234");
            Browser.driver.FindElement(By.Id("ContentPlaceHolder1_btnAccVerNxt")).Click();

        }
        public static void TakeScreenShot()
        {
            Screenshot ss = ((ITakesScreenshot)Browser.driver).GetScreenshot();
            ss.SaveAsFile("c:/desktop/Welcome_Page/", ImageFormat.Jpeg);
        }
        public static void ChooseBranch()
        {
            var select = Browser.driver.FindElement(By.Id("ContentPlaceHolder1_ddlBranch"));
            var state = select.FindElements(By.TagName("option"))[3];
            state.Click();
            Browser.driver.FindElement(By.Id("ContentPlaceHolder1_chkAgreeToTerms")).Click();
            Browser.driver.FindElement(By.Id("ContentPlaceHolder1_btnAuthTypeNxt")).Click();
        }
        public static void SelectImage()
        {
            Browser.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMinutes(20));
            Browser.driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromMinutes(10));
            Browser.driver.FindElement(By.CssSelector("css=#galleryDropdown")).Click();
        //  new SelectElement(Browser.driver.FindElement(By.Id("galleryDropdown"))).SelectByText("Flower");            
        //  var image = Browser.driver.FindElement(By.CssSelector("css=#5719 > div.gallery-img"));
        //  image.Click();
        }
    }
    public class Check_Request_Status
    {
        public static void Click()
        {
            Browser.driver.FindElement(By.PartialLinkText("Check Request")).Click();
        }
    }
    public class Image_GuideLines
    {
        public static void Click()
        {
            Browser.driver.FindElement(By.PartialLinkText("Image Guidelines")).Click();
        }
    }
    public class Vote_Here
    {
        public static void Click()
        {
            Browser.driver.FindElement(By.PartialLinkText("Vote Here")).Click();
        }
    }
        
    public class FAQs
    {
        public static void Click()
        {
            Browser.driver.FindElement(By.PartialLinkText("FAQs")).Click();
        }
    }
    public class Customer_Service
    {
        public static void Click()
        {
            Browser.driver.FindElement(By.PartialLinkText("Customer Service")).Click();
        }
    }
    
}

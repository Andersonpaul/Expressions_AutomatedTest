using System;
using FrameWork;
using NUnit.Framework;
namespace Test_Cases
{
    
    public class Smoke_Tests
    {       
        
        [Test]
        public void Navigate_1_Url()
        {
            URL.GoTo();
        }
       
        [Test]
        public void Navigate_2_Welcome_Page()
        {
            
              Welcome.Click();      
            //Welcome.Click_SideLinks();
            //Welcome.TakeScreenShot();
            //Welcome.AssertTitle("Expressions");
        }
        
         [Test]
        public void  Navigate_3_GetStarted_Page()
        {
            //Get_Started.PageLoadTimeOut(3);
            Get_Started.Click();
            //Get_Started.TakeScreenShot();
            Get_Started.EnterAccountNo();
            Get_Started.ChooseBranch();
            Get_Started.SelectImage();
        }
        /*
        
         [Test]
        public void Navigate_4_CheckRequestStatus_Page()
        {
            Check_Request_Status.Click();
        }
         [Test]
        public void Navigate_5_ImageGuideLines_Page()
        {
            Image_GuideLines.Click();
        }
         [Test]
        public void Navigate_6_VoteHere_Page()
        {
            Vote_Here.Click();
        }
         [Test]
        public void Navigate_7_FAQs_Page()
        {
            FAQs.Click();
        }
         [Test]
        public void Navigate_8_CustomerService_Page()
        {
            Customer_Service.Click();
        }
       */
    }
}

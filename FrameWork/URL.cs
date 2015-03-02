using System;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Base_Driver;

namespace FrameWork
{
    
    public static class URL
    {
       public static string url;
        public static void GoTo()
        {
           url = "http://expressions.firstbanknigeria.com";
           Browser.Navigate();           
           
        }

        
    }

   
}

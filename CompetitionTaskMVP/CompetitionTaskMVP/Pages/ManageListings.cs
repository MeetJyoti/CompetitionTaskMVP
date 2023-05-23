using CompetitionTaskMVP.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CompetitionTaskMVP.Pages
{
    public class ManageListings : CommonDriver
    {
        public void ManageListing(IWebDriver driver)
        {

            Thread.Sleep(2000);
            IWebElement ManageListings = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]"));
            ManageListings.Click();
        
        
        
        }



    }
}

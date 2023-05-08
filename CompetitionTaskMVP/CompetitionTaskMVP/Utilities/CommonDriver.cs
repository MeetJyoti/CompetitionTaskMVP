using CompetitionTaskMVP.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.DevTools.V109.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTaskMVP.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [SetUp]

        public void LoginStepsTest()
        {
            driver = new ChromeDriver();
            // Login Page
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);

        }

        [TearDown]
        public void CloseTest()
        {
            driver.Close();

        }
    }

}


using CompetitionTaskMVP.Pages;
using CompetitionTaskMVP.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoItX3Lib;
using AutoIt;
using System.Threading.Tasks;

namespace CompetitionTaskMVP.Tests
{
    [TestFixture]

    public class ShareSkills : CommonDriver
    {

        ShareSkillPage shareskillobj = new ShareSkillPage();



        [Test, Order(1)]
        public void CreateShareskills()
        {

            shareskillobj.ShareSkillActions(driver);






        }


    }
}

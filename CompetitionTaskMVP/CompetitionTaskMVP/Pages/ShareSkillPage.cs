using CompetitionTaskMVP.Utilities;
using OpenQA.Selenium;
using AutoItX3Lib;
using AutoIt;

namespace CompetitionTaskMVP.Pages
{
    public class ShareSkillPage: CommonDriver
    {
        
           
            public IWebElement AddNewSkillsButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));

            public IWebElement Title => driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));

            public IWebElement Description => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));

            public IWebElement Category => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select"));

            public IWebElement CategoryList => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]"));

            public IWebElement SubCategory => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));

            public IWebElement SubCategoryList => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]"));

            public IWebElement Tags => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input"));

            public IWebElement ServiceType => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));

             public IWebElement LocationType => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));

            public IWebElement StartDateInput => driver.FindElement(By.Name("startDate"));
            public IWebElement EndDate => driver.FindElement(By.Name("startDate"));

        //skill trade
        //skillexchnage

        //worksample - link
        public IWebElement Worksamples => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));

            public IWebElement ActiveCheckbox => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"))"));

            public IWebElement SaveButton => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));

      
        public void ShareSkillActions(string title)
        {

        }



    }
}

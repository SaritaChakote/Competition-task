using MarsFramework.Global;
using OpenQA.Selenium;
using Path = MarsFramework.Config.Path;
using System.Threading;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using MarsFramework.Config;

namespace MarsFramework.Pages
{
    public static class ShareSkill
    {
        public static IWebDriver driver = GlobalDefinitions.driver;
      

        public static void AddSkills()
        {
            // populate excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(1000);
            AccessWebElement.ButtonClick(driver, "XPath", Path.shareskill);
            Thread.Sleep(1000);
            AccessWebElement.InsertText(driver, "XPath", Path.Title, GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            AccessWebElement.InsertText(driver, "XPath", Path.Description, GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            AccessWebElement.InsertText(driver, "XPath", Path.Category, GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            AccessWebElement.InsertText(driver, "XPath", Path.Subcategory, GlobalDefinitions.ExcelLib.ReadData(2, "Subcategory"));
            AccessWebElement.InsertText(driver, "XPath", Path.Tags, GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input")).SendKeys(Keys.Enter);
            AccessWebElement.ButtonClick(driver, "XPath", Path.HourlyBasisService);
            AccessWebElement.ButtonClick(driver, "XPath", Path.Online);
        
            AccessWebElement.InsertText(driver, "XPath", Path.Enddate, GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));
            AccessWebElement.InsertText(driver, "XPath", Path.SunStarttime, GlobalDefinitions.ExcelLib.ReadData(2, "SunStarttime"));
            Console.WriteLine(Path.SunStarttime);
            AccessWebElement.InsertText(driver, "XPath", Path.SunEndtime, GlobalDefinitions.ExcelLib.ReadData(2, "SunEndtime"));
            AccessWebElement.InsertText(driver, "XPath", Path.MonStartime, GlobalDefinitions.ExcelLib.ReadData(2, "MonStarttime"));

           // Console.WriteLine(driver.FindElement(By.XPath(Path.MonStartime)).Text);
            //Assert.AreEqual("This email has already been used to register an account.", Webpages.HomePage.localDriver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/div")).Text);

            AccessWebElement.ButtonClick(driver, "XPath", Path.Skilltrade);
            AccessWebElement.InsertText(driver, "XPath", Path.SkillExange, GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchange"));
            
            driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")).SendKeys(Keys.Enter);
            AccessWebElement.ButtonClick(driver, "XPath", Path.Active);
            AccessWebElement.ButtonClick(driver, "XPath", Path.save);
            AccessWebElement.ButtonClick(driver, "XPath", ManageList.managelisting);

        }
    }

}
      
 


    
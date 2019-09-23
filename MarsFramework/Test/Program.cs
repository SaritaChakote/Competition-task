using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports.Model;
using MarsFramework.Global;
using TestAttribute = NUnit.Framework.TestAttribute;
using System.Threading;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;

namespace MarsFramework
{
    public class Program
    {
        public ChromeDriver IWebDriver { get; private set; }

        public static IWebDriver driver = GlobalDefinitions.driver;

        [SetUp]
        public void TestSetup()
        {

            Base.Inititalize();
            Pages.SignIn.LoginSteps();
        }

        [Test ]
        public void AddNewSkills()
            
        {
       
            Pages.ShareSkill.AddSkills();

            try
            {
                //Start the Reports
                Base.ExtentReports();
                Thread.Sleep(1000);
                Base.test = Base.extent.StartTest("Add Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "Manual Testing";
                string ActualValue = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[3]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed, Added Skill Successfully");
                    
                }

                else
                    Base.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }


        }

        [Test]
        public void EditAddedSkill()
        {
            Pages.ShareSkill.AddSkills();
            Pages.ManageListing.EditSkill();

        }

        [Test]
        public void DeleteSkill()
        {
            Pages.ShareSkill.AddSkills();
            Pages.ManageListing.DeleteSkill();

        }

        [TearDown]
        public void ClosingDown()
        {

        Global.Base.TearDown();

}
        }
        
    }

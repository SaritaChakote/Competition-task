using MarsFramework.Global;
using OpenQA.Selenium;
using System.Threading;
using MarsFramework.Config;

namespace MarsFramework.Pages

{
    public class SignIn
    {
        public static IWebDriver driver = GlobalDefinitions.driver;
        public static void LoginSteps()
        {
            //extent Reports
            Base.test = Base.extent.StartTest("Login Test");

            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");

            //Navigate to the Url
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(GlobalDefinitions.ExcelLib.ReadData(2,"Url"));

            //Click on Sign In tab
            AccessWebElement.ButtonClick(driver, "XPath", SignInP.signin);


            //Enter the data in Username textbox
            AccessWebElement.InsertText(driver, "XPath", SignInP.username, GlobalDefinitions.ExcelLib.ReadData(2,"Username"));
            Thread.Sleep(500);

            //Enter the password 
            AccessWebElement.InsertText(driver, "XPath", SignInP.password, GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Click on Login button
            AccessWebElement.ButtonClick(driver, "XPath", SignInP.login);
            Thread.Sleep(1500);

            //string text = GlobalDefinitions.driver.Title;

            //if (text == "Profile")
            //{
            //    Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successful");
            //}
            //else
            //    Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login Unsuccessful");

        }
    }
}
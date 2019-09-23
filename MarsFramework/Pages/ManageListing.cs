using MarsFramework.Config;
using MarsFramework.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class ManageListing
    {
        public static IWebDriver driver = GlobalDefinitions.driver;
       
    public static void EditSkill()
        {
           

            //string beforeXpath = "//th[text()='Language']//ancestor::thead//following-sibling::tbody";
            //IList<IWebElement> Skills = driver.FindElements(By.XPath(beforeXpath + "//tr//td[1]"));

            ////checking language list for English or Hindi and Updating it
            //for (int i = 1; i <= Languages.Count; i++)
            //{
            //    if (Languages[i - 1].Text.Equals("English") || Languages[i - 1].Text.Equals("Hindi"))
            //    {
            //        Driver.driver.FindElement(By.XPath(beforeXpath + "[" + i + "]//i[@class='outline write icon']")).Click();


                    AccessWebElement.ButtonClick(driver, "XPath", ManageList.edit);
        }

    public static void DeleteSkill()
        {
            
            AccessWebElement.ButtonClick(driver, "XPath", ManageList.remove);

        }

    


    }
}

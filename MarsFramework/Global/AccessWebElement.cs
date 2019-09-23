using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Global
{
    class AccessWebElement
    {
            public static void InsertText(IWebDriver driver, string elementLocatorType, string locator, string value)
            {
                if (elementLocatorType == "XPath")
                {
                    driver.FindElement(By.XPath(locator)).SendKeys(value);
                }
                else if (elementLocatorType == "Id")
                {
                    driver.FindElement(By.Id(locator)).SendKeys(value);
                }

            }
            public static void ButtonClick(IWebDriver driver, string elementLocatorType, string locator)
            {
                if (elementLocatorType == "XPath")
                {
                    driver.FindElement(By.XPath(locator)).Click();
                }
                else if (elementLocatorType == "Id")
                {
                    driver.FindElement(By.Id(locator)).Click();
                }

            }

        internal static void InsertText(IWebDriver driver, string v1, object signin, string v2)
        {
            throw new NotImplementedException();
        }
    }
    }


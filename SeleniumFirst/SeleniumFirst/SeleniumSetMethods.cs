﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        // Enter Text
        public static void EnterText(IWebdriver driver, string element, string value, string elementType)
        {
            IWebElement element = driver.FindElement(By.Id(element));

            if (elementType == "Id")
                IWebElement element = driver.FindElement(By.Id(element));
                

            if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        // click into a button, checkbox, option, etc
        public static void Click(IWebdriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).Click();

            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        // Selecting a drop down control
        public static void SelectDropDown(IWebdriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);

            if (elementType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        } 
    }
}

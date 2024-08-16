using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sel.SeleniumExtensions;


namespace Sel.Pages
{
    public class UI_125_JobTitle
    {
        By txtJobTitle = By.Id("ctl00_Main_content_ucJobTitleToOcc_txtJobTitle");

        By txtSuggestions = By.Id("ac_results");

        By ddJobOccupation = By.Id("ctl00_Main_content_ucJobTitleToOcc_ONETDropDownList");

        By rbWorkedPartTimeNo = By.CssSelector("label[for='ctl00_Main_content_ucJobTitleToOcc_rbl18MoPartTime_1']");

        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_125_JobTitle()
        {
            if (new[] { "PFL" }.Any(site => TestData.Site.Contains(site))) { return; }

            txtJobTitle.EnterText("Test", txtSuggestions);

            WaitForSuggestions(ddJobOccupation).SelectDropdownByIndex("1");

            rbWorkedPartTimeNo.IsPresent()?.Click();

            btnNext.Click();
        }
    }
}

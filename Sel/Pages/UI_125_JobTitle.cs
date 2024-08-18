using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sel.Utilities.SeleniumExtensions;
using Sel.Utilities;


namespace Sel.Pages
{
    public class UI_125_JobTitle
    {
        By txtJobTitle = By.CssSelector("input[id$=txtJobTitle]");

        By txtSuggestions = By.CssSelector("div[id=ac_results]");

        By ddJobOccupation = By.CssSelector("select[id$=ONETDropDownList]");

        By rbWorkedPartTimeNo = By.CssSelector("label[for$=rbl18MoPartTime_1]");

        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_125_JobTitle()
        {
            if (new[] { "PFL" }.Contains(TestData.StateAbbreviation!)) return;


                txtJobTitle.EnterText("Test", txtSuggestions);

                WaitForSuggestions(ddJobOccupation).SelectDropdownByIndex("1");

                rbWorkedPartTimeNo.Click();

            btnNext.Click();
        }
    }
}

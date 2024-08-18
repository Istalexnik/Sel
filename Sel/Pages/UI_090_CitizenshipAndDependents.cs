using OpenQA.Selenium;
using Sel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_090_CitizenshipAndDependents
    {
        By rbDependents = By.Id("ctl00_Main_content_ucDemographics_rblDependents_1");
        By ddHowManyDependents = By.Id("ctl00_Main_content_ucDemographics_ddlHowManyDependents");
        By ddMartialStatus = By.Id("ctl00_Main_content_ucDemographics_ddlMaritalStatus");
        By ddCitizenship = By.Id("ctl00_Main_content_ucDemographics_ddl_UI_Citizen");
        By rbDisability = By.Id("ctl00_Main_content_ucDemographics_rblDisability_1");
        By rbChildSupportDeductions = By.CssSelector("label[for= 'ctl00_Main_content_ucDemographics_rblChildSupport_1']");   
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_090_CitizenshipAndDependents()
        {
            if (!ddCitizenship.FindIt()) return;

            rbDependents.Click();

            ddHowManyDependents.SelectDropdownByIndex("1");

            ddMartialStatus.SelectDropdownByIndex("1");

            ddCitizenship.SelectDropdownByIndex("1");

            rbDisability.Click();

            rbChildSupportDeductions.Click();

            btnNext.WaitForElementToBeClickable().Click();

        }
    }
}

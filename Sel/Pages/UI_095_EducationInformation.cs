using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_095_EducationInformation
    {
        By ddHighestLevelEducation = By.Id("ctl00_Main_content_ucEducation_ddlIndEduLevel");
        By ddAttendingSchool = By.Id("ctl00_Main_content_ucEducation_ddlSchoolStatus");
        By rbPlansToAttendSchoolNo = By.CssSelector("label[for='ctl00_Main_content_ucEducation_rblPlanSchoolIn12Months_1']");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_095_EducationInformation()
        {
            if (new[] { "PFL" }.Any(site => TestData.Site.Contains(site))) { return; }


            ddHighestLevelEducation.IsPresent()?.SelectDropdownByIndex("1");

            ddAttendingSchool.IsPresent()?.SelectDropdownByValue("4");

            rbPlansToAttendSchoolNo.IsPresent()?.Click();

            btnNext.Click();

        }
    }
}

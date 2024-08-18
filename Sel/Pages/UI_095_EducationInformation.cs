using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sel.Utilities;

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
            if (new[] { "PFL" }.Contains(TestData.StateAbbreviation!)) return;


            ddHighestLevelEducation.SelectDropdownByIndex("1");

            ddAttendingSchool.SelectDropdownByValue("4");

            rbPlansToAttendSchoolNo.Click();

            btnNext.Click();

        }
    }
}

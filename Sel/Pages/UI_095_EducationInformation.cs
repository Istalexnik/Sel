namespace Sel.Pages
{
    public class UI_095_EducationInformation
    {
        By ddHighestLevelEducation = By.CssSelector("select[id$=ddlIndEduLevel]");
        By ddAttendingSchool = By.CssSelector("select[id$=ddlSchoolStatus]");
        By rbPlansToAttendSchoolNo = By.CssSelector("label[for$=rblPlanSchoolIn12Months_1]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_095_EducationInformation()
        {
            if (Helper.CheckPause(Enums.PageType.EducationInformation)) return;
            ddHighestLevelEducation.SelectDropdownByIndex("1");
            ddAttendingSchool.SelectDropdownByValue("4");
            rbPlansToAttendSchoolNo.Click();
            CheckInputs();
            btnNext.Click();
        }
    }
}
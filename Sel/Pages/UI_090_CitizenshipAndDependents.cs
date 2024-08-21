namespace Sel.Pages
{
    public class UI_090_CitizenshipAndDependents
    {
        By rbDependents = By.CssSelector("label[for$=rblDependents_1]");
        By ddHowManyDependents = By.CssSelector("select[id$=ddlHowManyDependents]");
        By ddMartialStatus = By.CssSelector("select[id$=ddlMaritalStatus]");
        By ddCitizenship = By.CssSelector("select[id$=ddl_UI_Citizen]");
        By rbDisability = By.CssSelector("label[for$=rblDisability_1]");
        By rbChildSupportDeductions = By.CssSelector("label[for$= rblChildSupport_1]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_090_CitizenshipAndDependents()
        {
            if (Helper.CheckPause(Enums.PageType.CitizenshipAndDependents)) return;

            rbDependents.Click();
            ddHowManyDependents.SelectDropdownByIndex("1");
            ddMartialStatus.SelectDropdownByIndex("1");
            ddCitizenship.SelectDropdownByIndex("1");
            rbDisability.Click();
            rbChildSupportDeductions.Click();
            CheckInputs();
            btnNext.Click();
        }
    }
}
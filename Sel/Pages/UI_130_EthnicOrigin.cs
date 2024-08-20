namespace Sel.Pages
{
    public class UI_130_EthnicOrigin
    {
        By rbHispanicNo = By.CssSelector("label[for$=rblHispanic_1]");
        By cbRace = By.CssSelector("label[for$=chkRaceList_1]");
        By rbLimitedEnglishNo = By.CssSelector("label[for$=rblLangSecondary_1]");
        By ddMaritalStatus = By.CssSelector("select[id$=ddlMaritalStatus]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_130_EthnicOrigin()
        {
            if (Helper.CheckPause(Enums.PageType.EthnicOrigin)) return;
            rbHispanicNo.Click();

            cbRace.Click();
            rbLimitedEnglishNo.Click();
            ddMaritalStatus.SelectDropdownByIndex("1");
            CheckInputs();
            btnNext.Click();
        }
    }
}
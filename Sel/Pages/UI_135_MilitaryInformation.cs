namespace Sel.Pages
{
    public class UI_135_MilitaryInformation
    {
        By rbSpouseNo = By.CssSelector("label[for$=rblSpouseEligiblePerson_1]");
        By rbVeteranNo = By.CssSelector("label[for$=rblMilitaryService_1]");
        By rbServed180DaysNo = By.CssSelector("label[for$=rblServedConsecutiveDaysInActiveDuty_1]");
        By ddClassifiedDisabledVeteran = By.CssSelector("select[id$=ddlClassifiedAsDisabledVeteran]");
        By rbWoundedYes = By.CssSelector("label[for$=rblWounded_0]");
        By rbTAPNo = By.CssSelector("label[for$=rblTAPWorkshop_1]");
        By rb24Or12OfdischargeNo = By.CssSelector("label[for$=rblTransitioningServiceMember_1]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_135_MilitaryInformation()
        {
            if (Helper.CheckPause(Enums.PageType.MilitaryInformation)) return;

            rbSpouseNo.Click();

            if (TestData.ClaimType != Enums.ClaimType.UCX)
            {
                rbVeteranNo.Click();
            }

            rbServed180DaysNo.Click();
            ddClassifiedDisabledVeteran.SelectDropdownByIndex("1");

            if (TestData.ClaimType == Enums.ClaimType.UCX)
            {
                rbWoundedYes.Click();
                rbTAPNo.Click();
                rb24Or12OfdischargeNo.Click();
            }
            CheckInputs();
            btnNext.Click();
        }
    }
}
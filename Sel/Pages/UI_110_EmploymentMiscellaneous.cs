namespace Sel.Pages
{
    public class UI_110_EmploymentMiscellaneous
    {
        By rbAttendingTrainingNo = By.CssSelector("label[for$=rblAttendingTraining_1]");
        By rbComissionBasisNo = By.CssSelector("label[for$=rblCommissionBasis_1]");
        By rbRefusedJobNo = By.CssSelector("label[for$=rblRefusedAJobOffer_1]");
        By rbRefusedReferralNo = By.CssSelector("label[for$=rblRefusedAReferralToWork_1]");
        By rbResultOfTradeNo = By.CssSelector("label[for$=rblCertifiedTrade_1]");
        By rbProfessionalAthleteNo = By.CssSelector("label[for$=rblWorkedAsProfessionalAthlete_1]");
        By rbHeadStartNo = By.CssSelector("label[for$=rblEmployedBySchool_1]");
        By btnNext = By.CssSelector("input[id$=btnNext]");
        public UI_110_EmploymentMiscellaneous()
        {
            if (Helper.CheckPause(Enums.PageType.EmploymentMiscellaneous)) return;
            rbAttendingTrainingNo.Click();
            rbComissionBasisNo.Click();
            rbRefusedJobNo.Click();
            rbRefusedReferralNo.Click();
            rbResultOfTradeNo.Click();
            rbProfessionalAthleteNo.Click();
            rbHeadStartNo.Click();
            CheckInputs();
            btnNext.Click();
        }
    }
}
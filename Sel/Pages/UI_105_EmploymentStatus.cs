namespace Sel.Pages
{
    public class UI_105_EmploymentStatus
    {
        By rbAcceptJobIfOfferedYes = By.CssSelector("label[for$=rblOfferedJobToday_0]");
        By rbBeenPhysicallyAbleToWorkYes = By.CssSelector("label[for$=rblPhysicallyAbleToWork_0]");
        By rbBeenAvailableToWorkYes = By.CssSelector("label[for$=rblAvailableToWork_0]");
        By rbSelfEmployedNo = By.CssSelector("label[for$=rblSelfEmployed_1]");
        By rbElectedOfficialNo = By.CssSelector("label[for$=rblElectedOfficial_1]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_105_EmploymentStatus()
        {
            if (Helper.CheckPause(Enums.PageType.EmploymentStatus)) return;
            rbAcceptJobIfOfferedYes.Click();
            rbBeenPhysicallyAbleToWorkYes.Click();
            rbBeenAvailableToWorkYes.Click();
            rbSelfEmployedNo.Click();
            rbElectedOfficialNo.Click();
            CheckInputs();
            btnNext.Click();
        }
    }
}
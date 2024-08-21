namespace Sel.Pages
{
    public class UI_045_WorkHistoryVerification
    {
        By rbDidYouWorkYes = By.CssSelector("label[for$=rblWorkHistoryVerify_0]");
        By btnNext = By.CssSelector("input[id$=StepNextButton]");

        public UI_045_WorkHistoryVerification()
        {
            if (Helper.CheckPause(Enums.PageType.WorkHistoryVerification)) return;

            rbDidYouWorkYes.Click();
            btnNext.Click();
        }
    }
}
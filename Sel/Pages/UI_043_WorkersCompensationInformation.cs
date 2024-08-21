namespace Sel.Pages
{
    public class UI_043_WorkersCompensationInformation
    {
        By rbReceivedWorkCompNo = By.CssSelector("label[for$=rblWCReceived_1]");
        By btnNext = By.CssSelector("input[id$=StepNextButton]");

        public UI_043_WorkersCompensationInformation()
        {
            if (Helper.CheckPause(Enums.PageType.WorkersCompensationInformation)) return;

            rbReceivedWorkCompNo.Click();
            btnNext.Click();
        }
    }
}
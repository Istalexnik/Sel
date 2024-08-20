namespace Sel.Pages
{
    public class UI_120_LaborUnion
    {
        By rbMemberNo = By.CssSelector("label[for$=rblUnionMember_1]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_120_LaborUnion()
        {
            if (Helper.CheckPause(Enums.PageType.LaborUnion)) return;
            rbMemberNo.Click();
            CheckInputs();
            btnNext.Click();
        }
    }
}
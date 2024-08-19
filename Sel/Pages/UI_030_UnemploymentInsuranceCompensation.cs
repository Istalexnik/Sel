namespace Sel.Pages
{
    public class UI_030_UnemploymentInsuranceCompemsation
    {
        By rbFilingUI = By.CssSelector("label[for$=radFilingUI_0]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_030_UnemploymentInsuranceCompemsation()
        {
            if (Helper.CheckPause(Enums.PageType.UnemploymentInsuranceCompensation)) return;
            rbFilingUI.Click();
            btnNext.Click();
        }
    }
}
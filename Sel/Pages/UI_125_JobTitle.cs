namespace Sel.Pages
{
    public class UI_125_JobTitle
    {
        By txtJobTitle = By.CssSelector("input[id$=txtJobTitle]");
        By txtSuggestions = By.CssSelector("div[id=ac_results]");
        By ddJobOccupation = By.CssSelector("select[id$=ONETDropDownList]");
        By rbWorkedPartTimeNo = By.CssSelector("label[for$=rbl18MoPartTime_1]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_125_JobTitle()
        {
            if (Helper.CheckPause(Enums.PageType.JobTitle)) return;
            txtJobTitle.EnterText("Test", txtSuggestions);
            WaitForSuggestions(ddJobOccupation).SelectDropdownByIndex("1");
            rbWorkedPartTimeNo.Click();
            CheckInputs();
            btnNext.Click();
        }
    }
}
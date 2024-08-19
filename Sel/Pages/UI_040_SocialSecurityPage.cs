namespace Sel.Pages
{
    public class UI_040_SocialSecurityPage
    {
        By txtSSN = By.CssSelector("input[id$=txtSSN]");
        By txtSSNReenter = By.CssSelector("input[id$=txtSSNReenter]");
        By btnNext = By.CssSelector("input[id$=StepNextButton]");

        public UI_040_SocialSecurityPage()
        {
            if (Helper.CheckPause(Enums.PageType.SocialSecurityPage)) return;
            txtSSN.SendKeys(TestData.SSN);
            txtSSNReenter.SendKeys(TestData.SSN);
            btnNext.Click();
        }
    }
}
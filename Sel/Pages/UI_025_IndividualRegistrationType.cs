namespace Sel.Pages
{
    public class UI_025_IndividualRegistrationType
    {
        By lnkRegistration = By.CssSelector("a[id$=lnkCompleteHeader]");

        public UI_025_IndividualRegistrationType()
        {
            if (Helper.CheckPause(Enums.PageType.IndividualRegistrationType)) return;

            lnkRegistration.Click();
        }
    }
}
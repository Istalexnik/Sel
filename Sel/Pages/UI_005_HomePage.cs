namespace Sel.Pages
{
    public class UI_005_HomePage
    {
        By ddLanguage = By.CssSelector("select[id=langtrig]");
        By btnLogin = By.CssSelector("button[id=btnguestlogina]");

        public UI_005_HomePage()
        {
            if (Helper.CheckPause(Enums.PageType.HomePage)) return;
            ddLanguage.SelectDropdownByValue("E");
            btnLogin.Click();
        }
    }
}
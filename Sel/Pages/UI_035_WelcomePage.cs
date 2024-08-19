namespace Sel.Pages
{
    public class UI_035_WelcomePage
    {
        By btnNext = By.CssSelector("input[id$=StartNextButton]");
        public UI_035_WelcomePage()
        {
            if (Helper.CheckPause(Enums.PageType.WelcomePage)) return;
            btnNext.Click();
        }
    }
}
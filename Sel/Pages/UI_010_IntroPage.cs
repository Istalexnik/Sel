using OpenQA.Selenium;
using Sel.Utilities;

namespace Sel.Pages
{
    public class UI_010_IntroPage
    {
        By btnRegistration = By.CssSelector("a[id=Loginintro_regagree]");

        public UI_010_IntroPage()
        {
            if (Helper.CheckPause(Enums.PageType.IntroPage)) return;
            btnRegistration.Click();
        }
    }
}

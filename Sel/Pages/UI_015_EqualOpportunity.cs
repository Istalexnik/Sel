using OpenQA.Selenium;
using Sel.Utilities;

namespace Sel.Pages
{
    public class UI_015_EqualOpportunity
    {
        By btnAgree = By.CssSelector("input[id$=btnAgree");
        public UI_015_EqualOpportunity()
        {
            if (Helper.CheckPause(Enums.PageType.EqualOpportunity)) return;
            btnAgree.Click();
        }
    }
}
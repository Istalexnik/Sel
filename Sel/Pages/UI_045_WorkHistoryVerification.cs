using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_045_WorkHistoryVerification
    {
        By rbDidYouWorkYes = By.CssSelector("label[for$=rblWorkHistoryVerify_0]");
        By rbDidYouWorkNo = By.CssSelector("label[for$=rblWorkHistoryVerify_1]");
        By btnNext = By.CssSelector("input[id$=StepNextButton]");

        public UI_045_WorkHistoryVerification()
        {
            if (!rbDidYouWorkYes.FindIt()) { return; }

            if (TestData.Type.Contains(7))
            {
                rbDidYouWorkNo.Click();
            }
            else
            {
                rbDidYouWorkYes.Click();
            }

            btnNext.Click();

        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_030_UnemploymentInsuranceCompemsation
    {
        By rbFilingUI = By.CssSelector("label[for$=radFilingUI_0]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_030_UnemploymentInsuranceCompemsation()
        {
            if (!rbFilingUI.FindIt()) { return; }

            rbFilingUI.Click();

            btnNext.Click();
        }

    }
}

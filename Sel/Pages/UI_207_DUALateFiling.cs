using OpenQA.Selenium;
using Sel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_207_DUALateFiling
    {
        By txtExplainWhyLate = By.Id("ffResponse5571");
        By rbEvidenceNo = By.CssSelector("label[for='ffResponse5572_1']");
        By txtExplainWhyNoEvidence = By.Id("ffResponse5574");

        By btnNext = By.Id("ctl00_Main_content_ucGSIButtons_btnNext");

        public UI_207_DUALateFiling()
        {
            if (!rbEvidenceNo.FindIt()) return;

            txtExplainWhyLate.EnterText("Test");
            rbEvidenceNo.Click();
            txtExplainWhyNoEvidence.WaitForElementToBeVisible().EnterText("Test");
            btnNext.Click();

        }
    }
}

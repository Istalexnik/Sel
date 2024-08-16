using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_120_LaborUnion
    {
        By titleLaborUnion = By.XPath("(//h2[text()='Labor Union Member'])");
        By rbMemberNo = By.Id("ctl00_Main_content_ucUILaborUnion_rblUnionMember_1");

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_120_LaborUnion()
        {
            if (new[] { "PFL" }.Any(site => TestData.Site.Contains(site))) { return; }
            if (!titleLaborUnion.FindIt()) { return; }

            rbMemberNo.Click();

            btnNext.Click();
        }
    }
}

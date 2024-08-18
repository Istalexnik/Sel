using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sel.Utilities;

namespace Sel.Pages
{
    public class UI_208_DUAQuestions
    {
        By txtDescribeInability = By.Id("ffResponse5575");
        By rbDirectResultYes = By.CssSelector("label[for='ffResponse5576_0']");
        By txtDescribeNature = By.Id("ffResponse5577");
        By txtFirstDayLimitation = By.Id("ctl00_Main_content_ucDynamicFormUserForm_ffResponse5578_dateInput");
        By rbUnableToWorkNo = By.CssSelector("label[for='ffResponse5582_1']");
        By rbUnableToReachPlaceNo = By.CssSelector("label[for='ffResponse5586_1']");
        By rbOpenForBussinessYes = By.CssSelector("label[for='ffResponse5587_0']");
        By rbNotifiedEmployerYes = By.CssSelector("label[for='ffResponse5589_0']");
        By txtProvideName = By.Id("ffResponse5590");
        By rbPositionHeldForYouYes = By.CssSelector("label[for='ffResponse5592_0']");

        By btnNext = By.Id("ctl00_Main_content_ucGSIButtons_btnNext");
        public UI_208_DUAQuestions()
        {
            if (!rbDirectResultYes.FindIt()) return;

            txtDescribeInability.SendKeys("Test");
            rbDirectResultYes.Click();
            txtDescribeNature.SendKeys("Test");
            txtFirstDayLimitation.SendKeys(TestData.WorkEndDate1);
            rbUnableToWorkNo.Click();
            rbUnableToReachPlaceNo.Click();
            rbOpenForBussinessYes.Click();
            rbNotifiedEmployerYes.Click();
            txtProvideName.WaitForElementToBeVisible().SendKeys("Test");

            rbPositionHeldForYouYes.Click();

            btnNext.Click();
        }
    }
}

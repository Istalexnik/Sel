namespace Sel.Pages
{
    public class UI_050_StatesYouWorkedIn
    {
        By rbWorkedInTwoStatesNo = By.CssSelector("label[for$=rblStatesWorkedIn_1]");
        By rbWorkedInTwoStatesYes = By.CssSelector("label[for$=rblStatesWorkedIn_0]");
        By rbClaimedUnemployment = By.CssSelector("label[for$=rblAppliedUCPast12Months_1]");
        By cbHostState = By.CssSelector("label[for$=chkStateHostState]");
        By cbOtherState = By.CssSelector("label[for$=chkStateList_9]");
        By btnNext = By.CssSelector("input[id$=StepNextButton]");
        By titleCreditWeeks = By.XPath("(//h2[text()='Credit Weeks'])");
        By txtQW1Q1 = By.CssSelector("input[id$=rptCreditWeeks_ctl00_txtQ1]");
        By txtQW1Q2 = By.CssSelector("input[id$=rptCreditWeeks_ctl00_txtQ2]");
        By txtQW1Q3 = By.CssSelector("input[id$=rptCreditWeeks_ctl00_txtQ3]");
        By txtQW1Q4 = By.CssSelector("input[id$=rptCreditWeeks_ctl00_txtQ4]");
        By txtQW1Q5 = By.CssSelector("input[id$=rptCreditWeeks_ctl00_txtQ5]");
        By txtQW2Q1 = By.CssSelector("input[id$=rptCreditWeeks_ctl02_txtQ1]");
        By txtQW2Q2 = By.CssSelector("input[id$=rptCreditWeeks_ctl02_txtQ2]");
        By txtQW2Q3 = By.CssSelector("input[id$=rptCreditWeeks_ctl02_txtQ3]");
        By txtQW2Q4 = By.CssSelector("input[id$=rptCreditWeeks_ctl02_txtQ4]");
        By txtQW2Q5 = By.CssSelector("input[id$=rptCreditWeeks_ctl02_txtQ5]");
        By rbWishToFileinHostStateYes = By.CssSelector("label[for$=rblFileInHostState_0]");
        By btnOk = By.CssSelector("input[id=btn-dialog-save]");

        public UI_050_StatesYouWorkedIn()
        {
            if (Helper.CheckPause(Enums.PageType.StatesYouWorkedIn)) return;

            if (TestData.ClaimType != Enums.ClaimType.CWC)
            {
                rbWorkedInTwoStatesNo.Click();
                rbClaimedUnemployment.Click();
                CheckInputs();
                btnNext.Click();

            }
            else
            {
                rbWorkedInTwoStatesYes.Click();
                rbClaimedUnemployment.Click();
                cbHostState.Click();
                cbOtherState.Click();
                btnNext.Click();

                if (titleCreditWeeks.FindIt())
                {
                    txtQW1Q1.SendKeys(TestData.CreditWeeks);
                    txtQW1Q2.SendKeys(TestData.CreditWeeks);
                    txtQW1Q3.SendKeys(TestData.CreditWeeks);
                    txtQW1Q4.SendKeys(TestData.CreditWeeks);
                    txtQW1Q5.SendKeys(TestData.CreditWeeks);
                    txtQW2Q1.SendKeys(TestData.CreditWeeks);
                    txtQW2Q2.SendKeys(TestData.CreditWeeks);
                    txtQW2Q3.SendKeys(TestData.CreditWeeks);
                    txtQW2Q4.SendKeys(TestData.CreditWeeks);
                    txtQW2Q5.SendKeys(TestData.CreditWeeks);
                    btnNext.Click();
                }

                rbWishToFileinHostStateYes.Click();
                btnOk.Click();
                CheckInputs();
                btnNext.Click();
            }
        }
    }
}
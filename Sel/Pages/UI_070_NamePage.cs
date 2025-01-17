﻿namespace Sel.Pages
{
    public class UI_070_NamePage
    {
        By txtFirstName = By.CssSelector("input[id$=txtFirstName]");
        By txtLastName = By.CssSelector("input[id$=txtLastName]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_070_NamePage()
        {
            if (Helper.CheckPause(Enums.PageType.NamePage)) return;

            txtFirstName.EnterText(TestData.FirstName);
            txtLastName.EnterText(TestData.LastName);
            CheckInputs();
            btnNext.Click();
        }
    }
}
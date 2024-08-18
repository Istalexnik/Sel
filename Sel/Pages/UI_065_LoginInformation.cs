using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sel.Data;
using System.Threading;
using Sel.Utilities;
namespace Sel.Pages
{
    public class UI_065_LoginInformation
    {
        By txtUsername = By.CssSelector("input[id$=txtUsername]");
        By txtPassword = By.CssSelector("input[id$=txtPwd]");
        By txtPassword2 = By.CssSelector("input[id$=txtPwdConfirm]");
        By ddSecurityQuestion = By.CssSelector("select[id$=ddlSecurityQuestion]");
        By txtSecurityResponse = By.CssSelector("input[id$=txtSecurityQuestionResponse]");
        By txtZip = By.CssSelector("input[id$=txtZip]");
        By rbAuthorizedToWork = By.CssSelector("label[for$=radAuthorizedToWork_0]");
        By txtEmail = By.CssSelector("input[id$=txtEmail]");
        By txtEmail2 = By.CssSelector("input[id$=txtEmailConfirm]");
        By txtDOB = By.CssSelector("input[id$=txtDOB]");
        By txtDOBConfirm = By.CssSelector("input[id$=txtDOBConfirm]");
        By txtCityOfBirth = By.CssSelector("input[id$=txtCityOfBirth]");
        By txtMothersName = By.CssSelector("input[id$=txtMothersMaidenName]");
        By rbGenderMail = By.CssSelector("label[for$=rblGender_1]");
        By rbBeenArrestedNo = By.CssSelector("label[for$=rblArrested_1]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_065_LoginInformation()
        {
            Helper.CheckPause(Enums.PageType.LoginInformation);

            txtUsername.SendKeys(TestData.Username);

            Thread.Sleep(300);

            txtPassword.WaitForElementToBeClickable().SendKeys(TestData.Password);

            txtPassword2.SendKeys(TestData.Password);

            ddSecurityQuestion.SelectDropdownByIndex("1");

            Thread.Sleep(100);

            txtSecurityResponse.SendKeys(TestData.SecurityResponse);

            Thread.Sleep(200);

            txtZip.WaitForElementToBeClickable().SendKeys(TestData.Zip);
            
            rbAuthorizedToWork.Click();

            txtEmail.WaitForElementToBeClickable().SendKeys(TestData.Email);

            txtEmail2.SendKeys(TestData.Email);

            txtDOB.SendKeys(TestData.DOB);

            txtDOBConfirm.SendKeys(TestData.DOB);

            txtCityOfBirth.SendKeys("Tampa");

            txtMothersName.SendKeys("Test");

            rbGenderMail.Click();

            rbBeenArrestedNo.Click();

            btnNext.Click();

        }
    }
}

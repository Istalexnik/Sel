using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sel.Data;
using System.Threading;
namespace Sel.Pages
{
    public class UI_065_LoginInformation
    {
        By txtUsername = By.Id("ctl00_Main_content_ucLogin_txtUsername");
        By txtPassword = By.Id("ctl00_Main_content_ucLogin_ucPassword_txtPwd");
        By txtPassword2 = By.Id("ctl00_Main_content_ucLogin_ucPassword_txtPwdConfirm");
        By ddSecurityQuestion = By.Id("ctl00_Main_content_ucLogin_ddlSecurityQuestion");
        By txtSecurityResponse = By.Id("txtSecurityQuestionResponse");
        By txtZip = By.Id("ctl00_Main_content_txtZip");
        By rbAuthorizedToWork = By.CssSelector("label[for='ctl00_Main_content_radAuthorizedToWork_0']");
        By txtEmail = By.Id("ctl00_Main_content_ucEmailTextBox_txtEmail");
        By txtEmail2 = By.Id("ctl00_Main_content_ucEmailTextBox_txtEmailConfirm");
        By txtDOB = By.Id("ctl00_Main_content_ucRegDemographics_txtDOB");
        By txtDOBConfirm = By.Id("ctl00_Main_content_ucRegDemographics_txtDOBConfirm");
        By txtCityOfBirth = By.Id("ctl00_Main_content_ucRegDemographics_txtCityOfBirth");
        By txtMothersName = By.Id("ctl00_Main_content_ucRegDemographics_txtMothersMaidenName");
        By rbGenderMail = By.CssSelector("label[for='ctl00_Main_content_ucRegDemographics_rblGender_1']");
        By rbBeenArrestedNo = By.CssSelector("label[for='ctl00_Main_content_ucRegDemographics_rblArrested_1']");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_065_LoginInformation()
        {
            txtUsername.SendKeys(TestData.Username);

            Thread.Sleep(300);

            txtPassword.WaitForElementToBeClickable().SendKeys(TestData.Password);

            txtPassword2.SendKeys(TestData.Password);

            ddSecurityQuestion.SelectDropdownByIndex("1");

            Thread.Sleep(100);

            txtSecurityResponse.SendKeys(TestData.SecurityResponse);

            Thread.Sleep(200);

            txtZip.WaitForElementToBeClickable().SendKeys(TestData.Zip);
            
            rbAuthorizedToWork.IsPresent()?.Click();

            txtEmail.WaitForElementToBeClickable().SendKeys(TestData.Email);

            txtEmail2.SendKeys(TestData.Email);

            txtDOB.SendKeys(TestData.DOB);

            txtDOBConfirm.IsPresent()?.SendKeys(TestData.DOB);

            txtCityOfBirth.IsPresent()?.SendKeys("Tampa");

            txtMothersName.IsPresent()?.SendKeys("Test");

            rbGenderMail.Click();

            rbBeenArrestedNo.IsPresent()?.Click();

            btnNext.Click();

        }
    }
}

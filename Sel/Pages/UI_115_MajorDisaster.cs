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
    public class UI_115_MajorDisaster
    {
        By rbMajorDisasterNo = By.Id("ctl00_Main_content_ucUIDUA_radUnempDueToDisaster_1");
        By rbMajorDisasterYes = By.Id("ctl00_Main_content_ucUIDUA_radUnempDueToDisaster_0");
        By ddWhatState = By.Id("ctl00_Main_content_ucUIDUA_ddlStateAffected");
        By ddWhatDisaster = By.Id("ctl00_Main_content_ucUIDUA_ddlDisaster");
        By ddWhatCounty = By.Id("ctl00_Main_content_ucUIDUA_ddlAffectedParish");
        By rbLiveInCountyYes = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radAffectedParishLive_0']");
        By rbWorkInCountyYes = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radAffectedParishWork_0']");
        By rbTravelInCountyYes = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radAffectedParishTravel_0']");
        By rbYourEmployerUnableToOperateNo = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radEmployerNotOperating_1']");
        By rbAffectedSelfEmploymentYes = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radSelfEmployAffected_0']");
        By rbWillResumeSelfEmploymentNo = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radSelfEmployResuming_1']");
        By rbSelfEmploymentFamilityMemberNo = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radSelfEmployFamilyMembers_1']");

        By rbWeekFollowingDisasterYes = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radWeekUnempAfterDisaster_0']");
        By rbUnableToReachPlaceYes = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radAbleToReachPlaceOfEmployment_0']");
        By rbPublicTransportationNo = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radAlternateTransportation_1']");
        By rbStartNewPlaceNo = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radAbleToReachNewPlaceOfEmployment_1']");
        By rbBreadWinnerNo = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radBreadwinner_1']");
        By rbInjuryNo = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radInjury_1']");
        By rbFishermanNo = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radFisherman_1']");
        By rbAgriculturalSeasonalNo = By.CssSelector("label[for='ctl00_Main_content_ucUIDUA_radAgriculturalSeasonal_1']");
        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_115_MajorDisaster()
        {
            if (new[] { "PFL" }.Contains(TestData.StateAbbreviation!)) return;

            if (!rbMajorDisasterNo.FindIt()) return;

            if (!TestData.Type.Contains(6))
            {
                rbMajorDisasterNo.Click();
            }
            else
            {
                rbMajorDisasterYes.Click();
                ddWhatState.SelectDropdownByIndex("1");
                ddWhatDisaster.SelectDropdownByIndex("1");
                ddWhatCounty.WaitForElementToBeVisible(20).SelectDropdownByIndex("1");
                rbLiveInCountyYes.WaitForElementToBeStaleAndRefind(20).Click();
                rbWorkInCountyYes.Click();
                rbTravelInCountyYes.Click();
                rbYourEmployerUnableToOperateNo.Click();
                rbAffectedSelfEmploymentYes.Click();
                rbWillResumeSelfEmploymentNo.Click();
                rbSelfEmploymentFamilityMemberNo.Click();
                rbWeekFollowingDisasterYes.Click();
                rbUnableToReachPlaceYes.Click();
                rbPublicTransportationNo.Click();
                rbStartNewPlaceNo.Click();
                rbBreadWinnerNo.Click();
                rbInjuryNo.Click();
                rbFishermanNo.Click();
                rbAgriculturalSeasonalNo.Click();
            }
            btnNext.Click();
        }
    }
}

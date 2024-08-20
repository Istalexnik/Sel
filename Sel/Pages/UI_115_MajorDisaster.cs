namespace Sel.Pages
{
    public class UI_115_MajorDisaster
    {
        By rbMajorDisasterNo = By.CssSelector("label[for$=radUnempDueToDisaster_1]");
        By rbMajorDisasterYes = By.CssSelector("label[for$=radUnempDueToDisaster_0]");
        By ddWhatState = By.CssSelector("select[id$=ddlStateAffected]");
        By ddWhatDisaster = By.CssSelector("select[id$=ddlDisaster]");
        By ddWhatCounty = By.CssSelector("select[id$=ddlAffectedParish]");
        By rbLiveInCountyYes = By.CssSelector("label[for$=radAffectedParishLive_0]");
        By rbWorkInCountyYes = By.CssSelector("label[for$=radAffectedParishWork_0]");
        By rbTravelInCountyYes = By.CssSelector("label[for$=radAffectedParishTravel_0]");
        By rbYourEmployerUnableToOperateNo = By.CssSelector("label[for$=radEmployerNotOperating_1]");
        By rbAffectedSelfEmploymentYes = By.CssSelector("label[for$=radSelfEmployAffected_0]");
        By rbWillResumeSelfEmploymentNo = By.CssSelector("label[for$=radSelfEmployResuming_1]");
        By rbSelfEmploymentFamilityMemberNo = By.CssSelector("label[for$=radSelfEmployFamilyMembers_1]");
        By rbWeekFollowingDisasterYes = By.CssSelector("label[for$=radWeekUnempAfterDisaster_0]");
        By rbUnableToReachPlaceYes = By.CssSelector("label[for$=radAbleToReachPlaceOfEmployment_0]");
        By rbPublicTransportationNo = By.CssSelector("label[for$=radAlternateTransportation_1]");
        By rbStartNewPlaceNo = By.CssSelector("label[for$=radAbleToReachNewPlaceOfEmployment_1]");
        By rbBreadWinnerNo = By.CssSelector("label[for$=radBreadwinner_1]");
        By rbInjuryNo = By.CssSelector("label[for$=radInjury_1]");
        By rbFishermanNo = By.CssSelector("label[for$=radFisherman_1]");
        By rbAgriculturalSeasonalNo = By.CssSelector("label[for$=radAgriculturalSeasonal_1]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_115_MajorDisaster()
        {
            if (Helper.CheckPause(Enums.PageType.MajorDisaster)) return;

            if (TestData.ClaimType != Enums.ClaimType.DUA)
            {
                rbMajorDisasterNo.Click();
            }
            else
            {
                rbMajorDisasterYes.Click();
                ddWhatState.SelectDropdownByIndex("1");
                ddWhatDisaster.SelectDropdownByIndex("1");
                ddWhatCounty.SelectDropdownByIndex("1");
                rbLiveInCountyYes.Click();
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
            CheckInputs();
            btnNext.Click();
        }
    }
}
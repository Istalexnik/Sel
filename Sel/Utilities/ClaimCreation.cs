using Sel.Pages;
using Sel.Data;
using System.Diagnostics;

namespace Sel.Utilities
{
    public class ClaimCreation
    {
        public void CreateClaim()
        {
            Debug.WriteLine(TestData.SSN);
            Debug.WriteLine(TestData.Username);
            Debug.WriteLine(TestData.Url);


            new UI_005_HomePage();

            new UI_010_IntroPage();

            new UI_015_EqualOpportunity();

            new UI_020_PrivacyAgreement();


            new UI_025_IndividualRegistrationType();

            new UI_030_UnemploymentInsuranceCompemsation();

            new UI_035_WelcomePage();

            new UI_040_SocialSecurityPage();

            new UI_043_WorkersCompensationInformation();

            new UI_045_WorkHistoryVerification();

            new UI_050_StatesYouWorkedIn();

            new UI_055_FederalService();

            new UI_060_MilitaryService();

            new UI_065_LoginInformation();

            new UI_070_NamePage();

            new UI_075_ResidentialAddress();

            new UI_080_PhoneNumber();

            new UI_085_NotficationMethod();

            new UI_090_CitizenshipAndDependents();

            new UI_095_EducationInformation();

            new UI_100_EmploymentInformation();

            new UI_105_EmploymentStatus();

            new UI_110_EmploymentMiscellaneous();

            new UI_115_MajorDisaster();

            new UI_120_LaborUnion();

            new UI_125_JobTitle();

            new UI_130_EthnicOrigin();

            new UI_135_MilitaryInformation();

            new UI_138_IdentificationInformation();

            new UI_140_PaymentInformation();

            new UI_143_VerifyYourIdentity();

            new UI_145_UnemploymentCompensation();

            new UI_180_EmploymentHistoryBeforeFirst();

            new UI_185_EmployerSearch(TestData.Employer1!);

            new UI_190_EmployerPage(TestData.Employer1!, TestData.WorkBeginDate1, TestData.WorkEndDate1);

            new UI_195_EmploymentHistoryAfterFirst();

            new UI_200_BasePeriodEmploymentInformation();

            new UI_205_UnemploymentInsuranceClaimConfirmation();

            new UI_206_Resume();

            new UI_207_DUALateFiling();

            new UI_208_DUAQuestions();

            new UI_210_ImportantAgreement();

            new UI_215_AcknowledgmentPage();

            new UI_220_BenefitsRightsInformation();

            new UI_225_ClaimConfirmation();
        }
    }
}

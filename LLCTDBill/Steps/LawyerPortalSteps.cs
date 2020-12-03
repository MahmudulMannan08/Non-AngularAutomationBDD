using LLCTDBill.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System.IO;
using System.Runtime.Remoting.Contexts;
using Newtonsoft.Json.Linq;

namespace LLCTDBill.Steps
{
    [Binding]
    public class LawyerPortalSteps : TestBase
    {
        private readonly ScenarioContext context;
        public static WebService webService;
        public static DealDetailsPage dealDetailsPage;
        public static HomePage homePage;
        public static AmendmentPage amendmentPage;
        public static MenuPage menuPage;
        public static DealHistoryPage dealHistoryPage;
        public static JObject jsonContent = null;
        public static string CreditAgrDateVal = null;

        public LawyerPortalSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"Send TD deal data without credit agreement field")]
        public void GivenSendTDDealDataWithoutCreditAgreementField()
        {
            webService = UIHelper.PageInit<WebService>(driver);
            webService.CreateTDDealWithoutCreditAgr("Montreal", "QC", DocumentType, TotalLoanAmount, "CreateDeal.bat", @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs\CreateTDDealResponse.xml");
        }

        [Then(@"I verify credit agreement fields with no data")]
        public void ThenIVerifyCreditAgreementFieldsWithNoData()
        {
            dealDetailsPage = UIHelper.PageInit<DealDetailsPage>(driver);
            dealDetailsPage.VerifyCreditFieldsEmpty(CreditAgrInfo, LoanAmount, CreditAgrName, CreditAgrDate);
        }

        [Then(@"Enter credit agreement field data and save")]
        public void ThenEnterCreditAgreementFieldDataAndSave()
        {
            CreditAgrDateVal = CurrentOrFutureDate("MM/dd/yyyy");
            dealDetailsPage.EnterCreditFieldsData(CreditAgrNameVal, CreditAgrDateVal);
        }

        [Given(@"Send TD Non QC deal data without credit agreement field")]
        public void GivenSendTDNonQCDealDataWithoutCreditAgreementField()
        {
            webService = UIHelper.PageInit<WebService>(driver);
            webService.CreateTDDealWithoutCreditAgr("Toronto", "ON", DocumentType_ON, TotalLoanAmount, "CreateDeal_ON.bat", @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs\CreateTDDealResponse_ON.xml");
        }

        [Then(@"I verify credit agreement fields are unavailable")]
        public void ThenIVerifyCreditAgreementFieldsAreUnavailable()
        {
            dealDetailsPage = UIHelper.PageInit<DealDetailsPage>(driver);
            dealDetailsPage.VerifyCreditFieldsUnavailable();
        }

        [Then(@"Enter transaction details data and save")]
        public void ThenEnterTransactionDetailsDataAndSave()
        {
            dealDetailsPage.EnterTransactionDetailsData();
        }

        [Then(@"I verify credit agreement fields")]
        public void ThenIVerifyCreditAgreementFields()
        {
            dealDetailsPage = UIHelper.PageInit<DealDetailsPage>(driver);
            dealDetailsPage.VerifyCreditFieldsData(CreditAgrInfo, LoanAmount, CreditAgrName, CreditAgrDate, TotalLoanAmount, CreditAgreementFormName, ConvertDateFormat(ResultWeekday, "MM/dd/yyyy"));
        }

        [Then(@"Verify lawyer data for credit agreement field")]
        public void ThenVerifyLawyerDataForCreditAgreementField()
        {
            dealDetailsPage = UIHelper.PageInit<DealDetailsPage>(driver);
            dealDetailsPage.VerifyCreditFieldsData(CreditAgrInfo, LoanAmount, CreditAgrName, CreditAgrDate, TotalLoanAmount, CreditAgrNameVal, CreditAgrDateVal);
        }

        [Then(@"Update credit agreement field data and save")]
        public void ThenUpdateCreditAgreementFieldDataAndSave()
        {
            dealDetailsPage.EnterCreditFieldsData(CreditAgrNameVal, UpdateCreditAgrDate);
        }

        [Given(@"Send TD Non QC deal data with credit agreement field")]
        public void GivenSendTDNonQCDealDataWithCreditAgreementField()
        {
            webService = UIHelper.PageInit<WebService>(driver);
            webService.CreateTDDealWithCreditAgr("Toronto", "ON", DocumentType_ON, "592334", CreditAgreementFormName, CreditAgreementDate, "R", TotalLoanAmount, "CreateDeal_CreditAgr_ON.bat", @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs\CreateTDDealCreditAgrResponse_ON.xml");
        }

        [Then(@"Update TD deal data with credit agreement")]
        public void ThenUpdateTDDealDataWithCreditAgreement()
        {
            webService = UIHelper.PageInit<WebService>(driver);
            webService.UpdateTDDealWithCreditAgr(WebService.ClosingDate, "Montreal", "QC", DocumentType, WebService.ResponseFCTURN, CreditAgreementFormNumberUpdate, CreditAgreementFormNameUpdate, CreditAgreementDateUpdate, TotalLoanAmountUpdate, "UpdateDeal_CreditAgreement.bat", @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs\UpdateTDDealCreditAgrResponse.xml");
            Thread.Sleep(5000);
        }

        [Then(@"Update TD deal data with credit agreement for shared field and credit agreement field")]
        public void ThenUpdateTDDealDataWithCreditAgreementForSharedFieldAndCreditAgreementField()
        {
            webService = UIHelper.PageInit<WebService>(driver);
            webService.UpdateTDDealWithCreditAgr(ClosingDateUpdate, "Montreal", "QC", DocumentType, WebService.ResponseFCTURN, CreditAgreementFormNumberUpdate, CreditAgreementFormNameUpdate, CreditAgreementDateUpdate, TotalLoanAmountUpdate, "UpdateDeal_CreditAgreement.bat", @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs\UpdateTDDealCreditAgrResponse.xml");
            Thread.Sleep(5000);
        }

        [Then(@"Update TD deal data without credit agreement for shared field")]
        public void ThenUpdateTDDealDataWithoutCreditAgreementForSharedField()
        {
            webService = UIHelper.PageInit<WebService>(driver);
            webService.UpdateTDDealWithoutCreditAgr(ClosingDateUpdate, "Montreal", "QC", DocumentType, WebService.ResponseFCTURN, TotalLoanAmount, "UpdateDeal.bat", @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs\UpdateTDDealResponse.xml");
            Thread.Sleep(5000);
        }

        [Then(@"Update TD deal data with credit agreement for shared field")]
        public void ThenUpdateTDDealDataWithCreditAgreementForSharedField()
        {
            webService = UIHelper.PageInit<WebService>(driver);
            webService.UpdateTDDealWithCreditAgr(ClosingDateUpdate, "Montreal", "QC", DocumentType, WebService.ResponseFCTURN, "592334", CreditAgreementFormName, CreditAgreementDate, TotalLoanAmount, "UpdateDeal_CreditAgreement.bat", @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs\UpdateTDDealCreditAgrResponse.xml");
        }

        [Then(@"Verify user is redirected to homepage upon any action")]
        public void ThenVerifyUserIsRedirectedToHomepageUponAnyAction()
        {
            homePage = UIHelper.PageInit<HomePage>(driver);
            homePage.VerifyRedirectionToHomepage("View Deal History");
        }

        [Then(@"Search deal on hompage")]
        public void ThenSearchDealOnHompage()
        {
            homePage = UIHelper.PageInit<HomePage>(driver);
            homePage.SearchDeal(WebService.MortgageNo);
        }

        [Then(@"Verify amendment icon for deal with amendments")]
        public void ThenVerifyAmendmentIconForDealWithAmendments()
        {
            homePage.VerifyDealAmendmentIcon(WebService.MortgageNo);
        }

        [Then(@"Verify amendment screen data for lender fields")]
        public void ThenVerifyAmendmentScreenDataForLenderFields()
        {
            amendmentPage = UIHelper.PageInit<AmendmentPage>(driver);
            List<string> UpdateValue = new List<string>();
            UpdateValue.Add(TotalLoanAmountUpdate);
            UpdateValue.Add(CreditAgreementFormNameUpdate);
            UpdateValue.Add(CreditAgreementDateUpdate);
            amendmentPage.VerifyLenderFieldAmendments(3, UpdateValue.ToArray());
        }

        [Then(@"Verify amendment screen data for shared fields")]
        public void ThenVerifyAmendmentScreenDataForSharedFields()
        {
            amendmentPage = UIHelper.PageInit<AmendmentPage>(driver);
            amendmentPage.VerifySharedFieldAmendments(WebService.ClosingDate, ClosingDateUpdate, "Accept");
        }

        [Then(@"Verify lender update for lender fields")]
        public void ThenVerifyLenderUpdateForLenderFields()
        {
            dealDetailsPage = UIHelper.PageInit<DealDetailsPage>(driver);
            dealDetailsPage.VerifyCreditFieldsData(CreditAgrInfo, LoanAmount, CreditAgrName, CreditAgrDate, TotalLoanAmountUpdate, CreditAgreementFormNameUpdate, ConvertStringDateFormat(CreditAgreementDateUpdate, "yyyy-MM-dd", "MM/dd/yyyy"));
        }

        [Then(@"Verify lender update for shared fields")]
        public void ThenVerifyLenderUpdateForSharedFields()
        {
            dealDetailsPage = UIHelper.PageInit<DealDetailsPage>(driver);
            dealDetailsPage.VerifySharedFieldsData(ClosingDateUpdate);
        }

        [Then(@"I verify deal history entry for lender amendment")]
        public void ThenIVerifyDealHistoryEntryForLenderAmendment()
        {
            menuPage = UIHelper.PageInit<MenuPage>(driver);
            menuPage.LeftMenuNavigate("View Deal History");

            dealHistoryPage = UIHelper.PageInit<DealHistoryPage>(driver);
            dealHistoryPage.VerifyDealHistoryActivity(1, LenderUsername, ActivityLenderAmendment);
        }

        [Then(@"I verify deal history entry for shared field lender amendment")]
        public void ThenIVerifyDealHistoryEntryForSharedFieldLenderAmendment()
        {
            menuPage = UIHelper.PageInit<MenuPage>(driver);
            menuPage.LeftMenuNavigate("View Deal History");

            dealHistoryPage = UIHelper.PageInit<DealHistoryPage>(driver);
            dealHistoryPage.VerifyDealHistoryActivity(1, LawyerUsername, ActivityClosingDateAmendment);
            dealHistoryPage.VerifyDealHistoryActivity(2, LenderUsername, ActivityLenderAmendment);
        }

        [Then(@"I verify deal history entry for lawyer amendment")]
        public void ThenIVerifyDealHistoryEntryForLawyerAmendment()
        {
            menuPage = UIHelper.PageInit<MenuPage>(driver);
            menuPage.LeftMenuNavigate("View Deal History");

            dealHistoryPage = UIHelper.PageInit<DealHistoryPage>(driver);
            dealHistoryPage.VerifyDealHistoryActivity(1, LawyerUsername, "Credit Agreement Name changed from " + CreditAgreementFormName + " to " + CreditAgrNameVal);
            dealHistoryPage.VerifyDealHistoryActivity(2, LawyerUsername, "Credit Agreement Date changed from " + ConvertStringDateFormat(CreditAgreementDate, "yyyy-MM-dd", "MMM dd/yyyy") + " to " + ConvertStringDateFormat(UpdateCreditAgrDate, "MM/dd/yyyy", "MMM dd/yyyy"));

            menuPage.LeftMenuNavigate("Deal Details");
        }

        [Then(@"I verify deal history entry for lawyer amendment on credit fields entry")]
        public void ThenIVerifyDealHistoryEntryForLawyerAmendmentOnCreditFieldsEntry()
        {
            menuPage = UIHelper.PageInit<MenuPage>(driver);
            menuPage.LeftMenuNavigate("View Deal History");

            dealHistoryPage = UIHelper.PageInit<DealHistoryPage>(driver);
            dealHistoryPage.VerifyDealHistoryActivity(1, LawyerUsername, "Credit Agreement Name changed to " + CreditAgrNameVal);
            dealHistoryPage.VerifyDealHistoryActivity(2, LawyerUsername, "Credit Agreement Date changed to " + ConvertStringDateFormat(CreditAgrDateVal, "MM/dd/yyyy", "MMM dd/yyyy"));

            menuPage.LeftMenuNavigate("Deal Details");
        }

        [Then(@"Acknowledge lender amendments")]
        public void ThenAcknowledgeLenderAmendments()
        {
            amendmentPage.AcknowledgeAmendment();
        }

    }
}

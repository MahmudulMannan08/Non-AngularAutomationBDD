using LLCTDBill.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace LLCTDBill.Steps
{
    [Binding]
    public class AcceptDealSteps : TestBase
    {

        private readonly ScenarioContext context;
        public static LoginPage loginPage;
        public static HomePage homePage;
        public static AcceptRejectDealPage acceptRejectDealPage;
        public static WebService webService;
        public static DealSummaryPage dealSummaryPage;

        public AcceptDealSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"Send TD deal data with credit agreement")]
        public void GivenSendTDDealDataWithCreditAgreement()
        {
            webService = UIHelper.PageInit<WebService>(driver);
            webService.CreateTDDealWithCreditAgr("Montreal", "QC", DocumentType, "592334", CreditAgreementFormName, CreditAgreementDate, "R", TotalLoanAmount, "CreateDeal_CreditAgreement.bat", @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs\CreateTDDealCreditAgrResponse.xml");
        }

        [Given(@"Login to lawyer portal")]
        public void GivenLoginToLawyerPortal()
        {
            UIHelper.GoTo<LoginPage>(LawyerPortal, false);

            loginPage = UIHelper.PageInit<LoginPage>(driver);
            loginPage.LoginToLawyerPortal(LawyerUsername, LawyerPassword);
        }

        [Then(@"Search pending acceptance deal")]
        public void ThenSearchPendingAcceptanceDeal()
        {
            homePage = UIHelper.PageInit<HomePage>(driver);
            var LenderReferenceNo = WebService.MortgageNo;
            //homePage.SearchPendingDeal("PROD BIZTALK0625115256");
            Thread.Sleep(20000);
            homePage.SearchPendingDeal(LenderReferenceNo);
        }

        [Then(@"Accept deal on lawyer portal")]
        public void ThenAcceptDealOnLawyerPortal()
        {
            acceptRejectDealPage = UIHelper.PageInit<AcceptRejectDealPage>(driver);
            acceptRejectDealPage.AcceptRejectDeal("Accept");
        }
    }
}

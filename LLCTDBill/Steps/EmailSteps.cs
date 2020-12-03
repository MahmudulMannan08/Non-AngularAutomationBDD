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
using NUnit.Framework;

namespace LLCTDBill.Steps
{
    [Binding]
    public class EmailSteps : TestBase
    {
        private readonly ScenarioContext context;
        public static OutlookLoginPage outlookLoginPage;
        public static OutlookInboxPage outlookInboxPage;

        public EmailSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"Login to outlook")]
        public void ThenLoginToOutlook()
        {
            UIHelper.GoTo<OutlookLoginPage>(OutlookURL, false);

            outlookLoginPage = UIHelper.PageInit<OutlookLoginPage>(driver);
            outlookLoginPage.LogintoOutlook(OutlookUsername, OutlookPassword);
        }

        [Then(@"Verify lender email to lawyer - new deal")]
        public void ThenVerifyLenderEmailToLawyer_NewDeal()
        {
            outlookInboxPage = UIHelper.PageInit<OutlookInboxPage>(driver);
            Assert.True(outlookInboxPage.SearchOutlookMailbox(driver, WebService.MortgageNo, "New Deal"));
        }

        [Then(@"Verify lender email to lawyer - lender amendment update existing")]
        public void ThenVerifyLenderEmailToLawyer_LenderAmendmentUpdateExisting()
        {
            Assert.True(outlookInboxPage.SearchOutlookMailbox(driver, WebService.MortgageNo, "Amendment(s) to Deal"));
            Assert.True(outlookInboxPage.VerifyEmailContent("Loan Amount has been changed from '" + TotalLoanAmount + "' to '" + TotalLoanAmountUpdate + "'"));
            Assert.True(outlookInboxPage.VerifyEmailContent("Credit Agreement Name has been changed from '" + CreditAgreementFormName + "' to '" + CreditAgreementFormNameUpdate + "'"));
            Assert.True(outlookInboxPage.VerifyEmailContent("Credit Agreement Date has been changed from '" + ConvertStringDateFormat(CreditAgreementDate, "yyyy-MM-dd", "M/d/yyyy") + "' to '" + ConvertStringDateFormat(CreditAgreementDateUpdate, "yyyy-MM-dd", "M/d/yyyy") + "'"));
        }

        [Then(@"Verify lender email to lawyer - lender amendment add new")]
        public void ThenVerifyLenderEmailToLawyer_LenderAmendmentAddNew()
        {
            Assert.True(outlookInboxPage.SearchOutlookMailbox(driver, WebService.MortgageNo, "Amendment(s) to Deal"));
            Assert.True(outlookInboxPage.VerifyEmailContent("Loan Amount has been changed from '" + TotalLoanAmount + "' to '" + TotalLoanAmountUpdate + "'"));
            Assert.True(outlookInboxPage.VerifyEmailContent("Credit Agreement Name has been changed from '' to '" + CreditAgreementFormNameUpdate + "'"));
            Assert.True(outlookInboxPage.VerifyEmailContent("Credit Agreement Date has been added (New value " + ConvertStringDateFormat(CreditAgreementDateUpdate, "yyyy-MM-dd", "M/d/yyyy") + ")"));
        }

    }
}

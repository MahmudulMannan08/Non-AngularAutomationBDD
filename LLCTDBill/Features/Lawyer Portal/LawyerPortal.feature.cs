// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace LLCTDBill.Features.LawyerPortal
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Lawyer Portal", Description="\tUser Stories: 3.1, 3.4, 2.3, 2.1, 6.11", SourceFile="Features\\Lawyer Portal\\LawyerPortal.feature", SourceLine=0)]
    public partial class LawyerPortalFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LawyerPortal.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Lawyer Portal", "\tUser Stories: 3.1, 3.4, 2.3, 2.1, 6.11", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("1. Lender Sent Deal With Credit Agreement Fields (QC)", Description=@"		3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With Credit Agreement Fields (QC) - UI & Edit-ability Rules
		2.1/LLC/Lawyer Portal - Amendment Screen - Lender Updates Credit Agreement Fields
		2.3/LLC/Lawyer Portal - Deal History - Create Deal History entry - Lawyer and Lender Amendment
		3.4/LLC/Lawyer Portal - Transaction Details Screen - Display Loan Amount in a read-only format
		6.11/LLC/Lender Integration - SendDealData with Credit Agreement - Lender Updates Credit Fields That Overwrites Lawyer Changes to Credit Fields", SourceLine=3)]
        public virtual void _1_LenderSentDealWithCreditAgreementFieldsQC()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1. Lender Sent Deal With Credit Agreement Fields (QC)", @"		3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With Credit Agreement Fields (QC) - UI & Edit-ability Rules
		2.1/LLC/Lawyer Portal - Amendment Screen - Lender Updates Credit Agreement Fields
		2.3/LLC/Lawyer Portal - Deal History - Create Deal History entry - Lawyer and Lender Amendment
		3.4/LLC/Lawyer Portal - Transaction Details Screen - Display Loan Amount in a read-only format
		6.11/LLC/Lender Integration - SendDealData with Credit Agreement - Lender Updates Credit Fields That Overwrites Lawyer Changes to Credit Fields", ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
 testRunner.Given("Send TD deal data with credit agreement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("Login to lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("Search pending acceptance deal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And("Accept deal on lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("I verify credit agreement fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.And("Update credit agreement field data and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("I verify deal history entry for lawyer amendment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.Then("Update TD deal data with credit agreement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.Then("Verify user is redirected to homepage upon any action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.Then("Search deal on hompage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.And("Verify amendment icon for deal with amendments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("Verify amendment screen data for lender fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("Acknowledge lender amendments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("Verify lender update for lender fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.Then("I verify deal history entry for lender amendment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("2. Lender Sent Deal Without Credit Agreement Fields (QC)", Description=@"		3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With No Credit Agreement Fields (QC) - UI & Edit-ability Rules
		2.1/LLC/Lawyer Portal - Amendment Screen - Lender Updates Other Fields
		2.3/LLC/Lawyer Portal - Deal History - Create Deal History entry - Lawyer and Lender Amendment
		3.4/LLC/Lawyer Portal - Transaction Details Screen - Display Loan Amount in a read-only format
		6.11/LLC/Lender Integration - SendDealData without Credit Agreement - Lender Updates Other Fields - Lawyer Change to Credit Agreement is Pertained", SourceLine=25)]
        public virtual void _2_LenderSentDealWithoutCreditAgreementFieldsQC()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2. Lender Sent Deal Without Credit Agreement Fields (QC)", @"		3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With No Credit Agreement Fields (QC) - UI & Edit-ability Rules
		2.1/LLC/Lawyer Portal - Amendment Screen - Lender Updates Other Fields
		2.3/LLC/Lawyer Portal - Deal History - Create Deal History entry - Lawyer and Lender Amendment
		3.4/LLC/Lawyer Portal - Transaction Details Screen - Display Loan Amount in a read-only format
		6.11/LLC/Lender Integration - SendDealData without Credit Agreement - Lender Updates Other Fields - Lawyer Change to Credit Agreement is Pertained", ((string[])(null)));
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 32
 testRunner.Given("Send TD deal data without credit agreement field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.And("Login to lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.Then("Search pending acceptance deal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.And("Accept deal on lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.Then("I verify credit agreement fields with no data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.And("Enter credit agreement field data and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("I verify deal history entry for lawyer amendment on credit fields entry", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("Update TD deal data without credit agreement for shared field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.Then("Verify user is redirected to homepage upon any action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.Then("Search deal on hompage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.And("Verify amendment icon for deal with amendments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("Verify amendment screen data for shared fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("Acknowledge lender amendments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("Verify lender update for shared fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("Verify lawyer data for credit agreement field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.Then("I verify deal history entry for shared field lender amendment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("3. SendDealData with Credit Agreement - Lawyer Change to Credit Agreement is Over" +
            "written by Lender Credit Values (QC)", Description="\t\t6.11/LLC/Lender Integration - SendDealData with Credit Agreement - Lender Updat" +
            "es Other Fields - Lawyer Change to Credit Agreement is Overwritten by Lender Cre" +
            "dit Values", SourceLine=48)]
        public virtual void _3_SendDealDataWithCreditAgreement_LawyerChangeToCreditAgreementIsOverwrittenByLenderCreditValuesQC()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3. SendDealData with Credit Agreement - Lawyer Change to Credit Agreement is Over" +
                    "written by Lender Credit Values (QC)", "\t\t6.11/LLC/Lender Integration - SendDealData with Credit Agreement - Lender Updat" +
                    "es Other Fields - Lawyer Change to Credit Agreement is Overwritten by Lender Cre" +
                    "dit Values", ((string[])(null)));
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 51
 testRunner.Given("Send TD deal data with credit agreement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
 testRunner.And("Login to lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.Then("Search pending acceptance deal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.And("Accept deal on lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.Then("I verify credit agreement fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.And("Update credit agreement field data and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("I verify deal history entry for lawyer amendment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.Then("Update TD deal data with credit agreement for shared field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.Then("Verify user is redirected to homepage upon any action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.Then("Search deal on hompage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.And("Verify amendment icon for deal with amendments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("Verify amendment screen data for shared fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("Acknowledge lender amendments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("Verify lender update for shared fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.Then("I verify credit agreement fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.Then("I verify deal history entry for shared field lender amendment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("4. SendDealData without Credit Agreement - Lawyer Change to Credit Agreement is O" +
            "verwritten by Lender Credit Values (QC)", Description="\t\t6.11/LLC/Lender Integration - SendDealData without Credit Agreement - Lender Up" +
            "dates with Credit Agreement Fields - Lawyer Change to Credit Agreement is Overwr" +
            "itten by Lender Credit Values", SourceLine=67)]
        public virtual void _4_SendDealDataWithoutCreditAgreement_LawyerChangeToCreditAgreementIsOverwrittenByLenderCreditValuesQC()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4. SendDealData without Credit Agreement - Lawyer Change to Credit Agreement is O" +
                    "verwritten by Lender Credit Values (QC)", "\t\t6.11/LLC/Lender Integration - SendDealData without Credit Agreement - Lender Up" +
                    "dates with Credit Agreement Fields - Lawyer Change to Credit Agreement is Overwr" +
                    "itten by Lender Credit Values", ((string[])(null)));
#line 68
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 70
 testRunner.Given("Send TD deal data without credit agreement field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 71
 testRunner.And("Login to lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.Then("Search pending acceptance deal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.And("Accept deal on lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.Then("I verify credit agreement fields with no data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.And("Enter credit agreement field data and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("I verify deal history entry for lawyer amendment on credit fields entry", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.Then("Update TD deal data with credit agreement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.Then("Verify user is redirected to homepage upon any action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.Then("Search deal on hompage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
 testRunner.And("Verify amendment icon for deal with amendments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("Verify amendment screen data for lender fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("Acknowledge lender amendments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("Verify lender update for lender fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.Then("I verify deal history entry for lender amendment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("5. SendDealData without Credit Agreement - Lender Updates Other Fields and includ" +
            "es Credit Agreement Fields", Description="\t\t6.11/LLC/Lender Integration - SendDealData without Credit Agreement - Lender Up" +
            "dates Other Fields and includes Credit Agreement Fields - Lawyer Change to Credi" +
            "t Agreement is Overwritten by Lender Credit Values", SourceLine=85)]
        public virtual void _5_SendDealDataWithoutCreditAgreement_LenderUpdatesOtherFieldsAndIncludesCreditAgreementFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5. SendDealData without Credit Agreement - Lender Updates Other Fields and includ" +
                    "es Credit Agreement Fields", "\t\t6.11/LLC/Lender Integration - SendDealData without Credit Agreement - Lender Up" +
                    "dates Other Fields and includes Credit Agreement Fields - Lawyer Change to Credi" +
                    "t Agreement is Overwritten by Lender Credit Values", ((string[])(null)));
#line 86
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 88
 testRunner.Given("Send TD deal data without credit agreement field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
 testRunner.And("Login to lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.Then("Search pending acceptance deal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.And("Accept deal on lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.Then("I verify credit agreement fields with no data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
 testRunner.And("Enter credit agreement field data and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("I verify deal history entry for lawyer amendment on credit fields entry", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.Then("Update TD deal data with credit agreement for shared field and credit agreement f" +
                    "ield", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.Then("Verify user is redirected to homepage upon any action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.Then("Search deal on hompage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.And("Verify amendment icon for deal with amendments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("Verify amendment screen data for lender fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And("Verify amendment screen data for shared fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("Acknowledge lender amendments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("Verify lender update for shared fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("Verify lender update for lender fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.Then("I verify deal history entry for shared field lender amendment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("A. Lender Sent Deal With Credit Agreement Fields (Other Than QC)", Description="\t\t3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With Cred" +
            "it Agreement Fields (Other Than QC) - UI & Edit-ability Rules", SourceLine=105)]
        public virtual void A_LenderSentDealWithCreditAgreementFieldsOtherThanQC()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A. Lender Sent Deal With Credit Agreement Fields (Other Than QC)", "\t\t3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With Cred" +
                    "it Agreement Fields (Other Than QC) - UI & Edit-ability Rules", ((string[])(null)));
#line 106
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 108
 testRunner.Given("Send TD Non QC deal data with credit agreement field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 109
 testRunner.And("Login to lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.Then("Search pending acceptance deal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.And("Accept deal on lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.Then("I verify credit agreement fields are unavailable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.And("Enter transaction details data and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("B. Lender Sent Deal With No Credit Agreement Fields (Other Than QC)", Description="\t\t3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With No C" +
            "redit Agreement Fields (Other Than QC) - UI & Edit-ability Rules", SourceLine=114)]
        public virtual void B_LenderSentDealWithNoCreditAgreementFieldsOtherThanQC()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("B. Lender Sent Deal With No Credit Agreement Fields (Other Than QC)", "\t\t3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With No C" +
                    "redit Agreement Fields (Other Than QC) - UI & Edit-ability Rules", ((string[])(null)));
#line 115
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 117
 testRunner.Given("Send TD Non QC deal data without credit agreement field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 118
 testRunner.And("Login to lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.Then("Search pending acceptance deal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
 testRunner.And("Accept deal on lawyer portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.Then("I verify credit agreement fields are unavailable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
 testRunner.And("Enter transaction details data and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
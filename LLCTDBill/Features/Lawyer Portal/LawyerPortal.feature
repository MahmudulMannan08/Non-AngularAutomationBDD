Feature: Lawyer Portal
	User Stories: 3.1, 3.4, 2.3, 2.1, 6.11

Scenario: 1. Lender Sent Deal With Credit Agreement Fields (QC)
		3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With Credit Agreement Fields (QC) - UI & Edit-ability Rules
		2.1/LLC/Lawyer Portal - Amendment Screen - Lender Updates Credit Agreement Fields
		2.3/LLC/Lawyer Portal - Deal History - Create Deal History entry - Lawyer and Lender Amendment
		3.4/LLC/Lawyer Portal - Transaction Details Screen - Display Loan Amount in a read-only format
		6.11/LLC/Lender Integration - SendDealData with Credit Agreement - Lender Updates Credit Fields That Overwrites Lawyer Changes to Credit Fields
	Given Send TD deal data with credit agreement
	And Login to lawyer portal
	Then Search pending acceptance deal
	And Accept deal on lawyer portal
	Then I verify credit agreement fields
	And Update credit agreement field data and save
	And I verify deal history entry for lawyer amendment
	Then Update TD deal data with credit agreement
	Then Verify user is redirected to homepage upon any action
	Then Search deal on hompage
	And Verify amendment icon for deal with amendments
	And Verify amendment screen data for lender fields
	And Acknowledge lender amendments
	And Verify lender update for lender fields
	Then I verify deal history entry for lender amendment

Scenario: 2. Lender Sent Deal Without Credit Agreement Fields (QC)
		3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With No Credit Agreement Fields (QC) - UI & Edit-ability Rules
		2.1/LLC/Lawyer Portal - Amendment Screen - Lender Updates Other Fields
		2.3/LLC/Lawyer Portal - Deal History - Create Deal History entry - Lawyer and Lender Amendment
		3.4/LLC/Lawyer Portal - Transaction Details Screen - Display Loan Amount in a read-only format
		6.11/LLC/Lender Integration - SendDealData without Credit Agreement - Lender Updates Other Fields - Lawyer Change to Credit Agreement is Pertained
	Given Send TD deal data without credit agreement field
	And Login to lawyer portal
	Then Search pending acceptance deal
	And Accept deal on lawyer portal
	Then I verify credit agreement fields with no data
	And Enter credit agreement field data and save
	And I verify deal history entry for lawyer amendment on credit fields entry
	Then Update TD deal data without credit agreement for shared field
	Then Verify user is redirected to homepage upon any action
	Then Search deal on hompage
	And Verify amendment icon for deal with amendments
	And Verify amendment screen data for shared fields
	And Acknowledge lender amendments
	And Verify lender update for shared fields
	And Verify lawyer data for credit agreement field
	Then I verify deal history entry for shared field lender amendment

Scenario: 3. SendDealData with Credit Agreement - Lawyer Change to Credit Agreement is Overwritten by Lender Credit Values (QC)
		6.11/LLC/Lender Integration - SendDealData with Credit Agreement - Lender Updates Other Fields - Lawyer Change to Credit Agreement is Overwritten by Lender Credit Values
	Given Send TD deal data with credit agreement
	And Login to lawyer portal
	Then Search pending acceptance deal
	And Accept deal on lawyer portal
	Then I verify credit agreement fields
	And Update credit agreement field data and save
	And I verify deal history entry for lawyer amendment
	Then Update TD deal data with credit agreement for shared field
	Then Verify user is redirected to homepage upon any action
	Then Search deal on hompage
	And Verify amendment icon for deal with amendments
	And Verify amendment screen data for shared fields
	And Acknowledge lender amendments
	And Verify lender update for shared fields
	Then I verify credit agreement fields
	Then I verify deal history entry for shared field lender amendment

Scenario: 4. SendDealData without Credit Agreement - Lawyer Change to Credit Agreement is Overwritten by Lender Credit Values (QC)
		6.11/LLC/Lender Integration - SendDealData without Credit Agreement - Lender Updates with Credit Agreement Fields - Lawyer Change to Credit Agreement is Overwritten by Lender Credit Values
	Given Send TD deal data without credit agreement field
	And Login to lawyer portal
	Then Search pending acceptance deal
	And Accept deal on lawyer portal
	Then I verify credit agreement fields with no data
	And Enter credit agreement field data and save
	And I verify deal history entry for lawyer amendment on credit fields entry
	Then Update TD deal data with credit agreement
	Then Verify user is redirected to homepage upon any action
	Then Search deal on hompage
	And Verify amendment icon for deal with amendments
	And Verify amendment screen data for lender fields
	And Acknowledge lender amendments
	And Verify lender update for lender fields
	Then I verify deal history entry for lender amendment

Scenario: 5. SendDealData without Credit Agreement - Lender Updates Other Fields and includes Credit Agreement Fields
		6.11/LLC/Lender Integration - SendDealData without Credit Agreement - Lender Updates Other Fields and includes Credit Agreement Fields - Lawyer Change to Credit Agreement is Overwritten by Lender Credit Values
	Given Send TD deal data without credit agreement field
	And Login to lawyer portal
	Then Search pending acceptance deal
	And Accept deal on lawyer portal
	Then I verify credit agreement fields with no data
	And Enter credit agreement field data and save
	And I verify deal history entry for lawyer amendment on credit fields entry
	Then Update TD deal data with credit agreement for shared field and credit agreement field
	Then Verify user is redirected to homepage upon any action
	Then Search deal on hompage
	And Verify amendment icon for deal with amendments
	And Verify amendment screen data for lender fields
	And Verify amendment screen data for shared fields
	And Acknowledge lender amendments
	And Verify lender update for shared fields
	And Verify lender update for lender fields
	Then I verify deal history entry for shared field lender amendment

Scenario: A. Lender Sent Deal With Credit Agreement Fields (Other Than QC)
		3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With Credit Agreement Fields (Other Than QC) - UI & Edit-ability Rules
	Given Send TD Non QC deal data with credit agreement field
	And Login to lawyer portal
	Then Search pending acceptance deal
	And Accept deal on lawyer portal
	Then I verify credit agreement fields are unavailable
	And Enter transaction details data and save

Scenario: B. Lender Sent Deal With No Credit Agreement Fields (Other Than QC)
		3.1/LLC/Lawyer Portal - Transaction Details Screen - Lender Sent Deal With No Credit Agreement Fields (Other Than QC) - UI & Edit-ability Rules
	Given Send TD Non QC deal data without credit agreement field
	And Login to lawyer portal
	Then Search pending acceptance deal
	And Accept deal on lawyer portal
	Then I verify credit agreement fields are unavailable
	And Enter transaction details data and save
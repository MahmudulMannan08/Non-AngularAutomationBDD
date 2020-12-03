Feature: Email
	User Stories: 2.2

Scenario: 1. Email to lawyer - Lender amendment for lender fields
		2.2/LLC/Emails - Email to Lawyer - Lender Changes Credit Agreement Information Field (QC)
	Given Send TD deal data with credit agreement
	And Login to lawyer portal
	Then Search pending acceptance deal
	And Accept deal on lawyer portal
	Then I verify credit agreement fields
	Then Update TD deal data with credit agreement
	Then Login to outlook
	And Verify lender email to lawyer - new deal
	And Verify lender email to lawyer - lender amendment update existing

Scenario: 2. Email to lawyer - Lender amendment for lender fields
		2.2/LLC/Emails - Email to Lawyer - Lender Enters Credit Agreement Information Field (QC)
	Given Send TD deal data without credit agreement field
	And Login to lawyer portal
	Then Search pending acceptance deal
	And Accept deal on lawyer portal
	Then I verify credit agreement fields with no data
	Then Update TD deal data with credit agreement
	Then Login to outlook
	And Verify lender email to lawyer - new deal
	And Verify lender email to lawyer - lender amendment add new
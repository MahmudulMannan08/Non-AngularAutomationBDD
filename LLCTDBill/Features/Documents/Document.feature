Feature: Document
	User Stories: 5.1, 5.2, 5.1a

Scenario: 1. Documents - Deed of loan - Mandatory requirements
		5.2/LLC/Lawyer Portal - Generate Deed of Collateral Hypothec (EN & FR) - New deal\Validate Error message to display when Credit agreement fields are incompleted
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
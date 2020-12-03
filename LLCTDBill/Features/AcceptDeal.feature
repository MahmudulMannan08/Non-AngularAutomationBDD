Feature: AcceptDeal
	Create TD Deal with new credit agreement fields
	Accept deal in lawyer portal

Scenario: Create TD Deal, Login, Accept Deal, Logout
	Given Send TD deal data with credit agreement
	And Login to lawyer portal
	Then Search pending acceptance deal
	And Accept deal on lawyer portal

Feature: AudenLoans

Background: 
     Given I am on the auden short term loan page

Scenario: The selected slider amount is loan amount

	When  I select a slider amount of 370
	Then I should see that the loan amount is equal to the slider amount

Scenario: The maximum slider amount is 500

	When  I attempt to increment the slider to a position higher than 500
	Then I should see that the maximum amount is 500

Scenario: The minimum slider amount is 200

	When  I attempt to increment the slider to a position lower than 200
	Then I should see that the minimum amount is 200


Scenario: Weekend Payment Dates default to the date of the previous Friday

	When I set the repayment date to a weekend date
	Then the repayment date should default to the date of the friday that just passed
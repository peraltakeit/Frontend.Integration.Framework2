Feature: Test
	In order to test my repo
	As a user
	I want to be able to run this test

@test
Scenario: Test
	Given I am on the test page
	When I click the sign in button
	Then I should be taken to the sign in page
	When I enter "keithearthstone" into the email field
	And I click the next button
	Then the "Welcome" header should be displayed
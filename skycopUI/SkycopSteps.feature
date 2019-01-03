Feature: SkycopSteps

Scenario: Fill claim form
	Given I Open Skycop claim page
	When I enter test airports
	And I fill in flight details
	And I fill in traveller details
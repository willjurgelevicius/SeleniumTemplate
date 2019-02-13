Feature: SkycopSteps

Scenario: Open Skycop claims page
	Given I navigate to claims
	Then I set Kaunas as departure airport
	And I set London Gatwick as arrival airport
	And I select airlines
	And I enter flight number
Feature: Unregistered Vehicle Permit
	In order to avoid fines and penalities
	As an Vehicle Owner
	I want to get an unregistered vehicle permit

@motorcycle @progression @interview
Scenario Outline: Verify whether User can enrol for Unregistered Vehicle Permit
	#Step-1
	Given I provide my '<vehicleType>','<Address>','<permitStartDate>','<permitDuration>'
	And I click on the Calculate button
	#Step-2

#	@source:uvpData.xlsx:Sheet1
	Examples: 
	| vehicleType       | Address                           | permitStartDate | permitDuration |
	| Passenger Vehicle | 700 Bourke St, DOCKLANDS VIC 3008 | default         | 2 days         |
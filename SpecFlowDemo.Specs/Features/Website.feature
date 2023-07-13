Feature: Calculator Website

Simple web-based calculator for adding and subtracting numbers

Scenario: The calculator displays
	Given I have browsed to the calculator page
	Then The calculator should be displayed

Scenario: Add two numbers
	Given I have browsed to the calculator page
	When A number of 5 is entered
	And The action is set to Add
	And A number of 7 is entered
	And The result is calculated
	Then The result should be 12

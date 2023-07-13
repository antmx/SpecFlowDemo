Feature: Calculator
Simple calculator for adding and subtracting numbers

Scenario: Add two numbers
	Given I have a blank calculator
	When the first number of 50 is entered
	And the action is set to Add
	And the next number of 70 is entered
	And the result is calculated
	Then the result should be 120

Scenario Outline: Add two numbers with examples
	Given I have a blank calculator
	When the first number of <FirstNumber> is entered
	And the action is set to Add
	And the next number of <SecondNumber> is entered
	And the result is calculated
	Then the result should be <ExpectedResult>
Examples:
| FirstNumber | SecondNumber | ExpectedResult |
| 0           | 0            | 0              |
| 1           | 2            | 3              |
| 2           | 3            | 5              |
| 1.11        | 2.22         | 3.33           |

Scenario: Add three numbers
	Given I have a blank calculator
	When the first number of 50 is entered
	And the action is set to Add
	And the next number of 70 is entered
	And the result is calculated
	And the action is set to Add
	And the next number of 90 is entered
	And the result is calculated
	Then the result should be 210

Scenario: Clear the results
	Given I have a blank calculator
	When the first number of 50 is entered
	Then the result should be 50
	When the calculator is cleared
	Then the result should be 0

Scenario: Repeat last action
	Given I have a blank calculator
	When the first number of 50 is entered
	And the action is set to Add
	And the next number of 70 is entered
	And the result is calculated
	Then the result should be 120
	When the result is calculated
	Then the result should be 190

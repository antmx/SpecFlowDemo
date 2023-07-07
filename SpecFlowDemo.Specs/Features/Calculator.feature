Feature: Calculator
Simple calculator for adding numbers

Scenario: Add two numbers
	Given I have a blank calculator
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario Outline: Add two numbers with examples
	Given I have a blank calculator
	Given the first number is <FirstNumber>
	And the second number is <SecondNumber>
	When the two numbers are added
	Then the result should be <ExpectedResult>
Examples:
| FirstNumber | SecondNumber | ExpectedResult |
| 0           | 0            | 0              |
| 1           | 2            | 3              |
| 2           | 3            | 5              |
| 1.11        | 2.22         | 3.33           |

Scenario: Add three numbers
	Given I have a blank calculator
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Given the next number is 90
	When the two numbers are added
	Then the result should be 210
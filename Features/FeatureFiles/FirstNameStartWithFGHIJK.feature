Feature: First Name Starting With FGHIJK

Scenario: check link for  first name starting with F-G-H-I-J-K entered 
    Given the user is on the dotnetfiddle.net landing page 
	And I set '<fname>' in the input box
	When '<fname>' click share button 
    Then I should see link https://dotnetfiddle.net/

Examples:
| fname | 
| Henry |



Feature: First Name Starts With ABCDE

Scenario: nUnit Package added for first name start with A-B-C-D-E
    Given the user is on the dotnetfiddle.net landing page 
	And I set '<fname>' in the input box	
	And '<fname>' starts with letter A-B-C-D-E with NUnit set for NuGet Packages
    Then I should see Package added

 Examples:
| fname |
| Diane |





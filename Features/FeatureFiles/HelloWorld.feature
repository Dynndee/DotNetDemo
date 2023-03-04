Feature: Hello World

Scenario: Hello world display in output on run click
     Given the user is on the dotnetfiddle.net landing page 
	When I click run button 
    Then I should see 'Hello World' in output window
Feature: First Name Starts With VWXYZ


Scenario: first name start with V-W-X-Y-Z click on Getting started button option
Given the user is on the dotnetfiddle.net landing page 
And I set '<fname>' in the input box
When I '<fname>' click on getting started button option
Then < Back to Editor button should appear

Examples:
| fname |
| William |
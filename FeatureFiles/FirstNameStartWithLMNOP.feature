Feature: First Name Start With LMNOP


Scenario: first name start with L-M-N-O-P click on "<" button option
Given the user is on the dotnetfiddle.net landing page 
And I set '<fname>' in the input box
When I '<fname>' click on < button  option
Then option panel is hidden

Examples:
| fname |
| Larry |
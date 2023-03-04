Feature: First Name Starts With QRSTU


Scenario: first name start with Q-R-S-T-U click on save button option
Given the user is on the dotnetfiddle.net landing page 
And I set '<fname>' in the input box
When  '<fname>' click  save button 
Then log in window should appear

Examples:
| fname |
| Queen |
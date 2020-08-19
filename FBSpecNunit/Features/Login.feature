Feature: Login
	
Background:
Given User should be on homepage

Scenario: Test login functionality
	
	And   Enter username and password
	When  Click on SignIn button
	Then  User is sucessfully login


Scenario: Test btob login functionality
	When Click on Travelagent tab
	And   Enter Username and Password
	| UserName | Password  |
	| FBTEST   | FBTEST123 |

	And   Click on btob SignIn button
	Then  User is sucessfully login for btob 
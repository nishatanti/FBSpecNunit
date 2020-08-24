Feature: Gmail
	


Scenario: Verify the recieved mail of jabatalks
	Given User is on Signup Page
	And   Select language from dropdown
	When  Enter name and organisation
	And   Enter email address
	And   Click on I agree option
	And   Click  on signup button
	Then  A validation message appear on the page


Scenario: Verify the functionality of Dutch language dropdown
	Given User is on Signup Page
	When  Click on language dropdown
	And   Select Dutch language from dropdown
	Then  All the details of page comes in dutch language


Scenario: Verify the functionality of English language dropdown
	Given User is on Signup Page
	When  Click on language dropdown
	And   Select English language from dropdown
	Then  All the details of page comes in English language



Scenario: Verify the email in inbox
	Given User is on Email Page
	When  search for jabatalks keyword	
	Then  Inbox should display result of search
	

Scenario: Verify recived email in tempinbox
	Given User is on Email Page
	And   copy email address
	And   User is on Signup Page one
	And   Select language from dropdown
	When  Enter name and organisation
	And   Enter email address one
	And   Click on I agree option
	And   Click  on signup button
	Then  Move to Email page 
	And   Inbox should display result of search


   
Scenario: Verify ymail

   Given User is on yahoomail page
   When Enter username and passwordd
   And  click next btn
   Then Yahoomail is open sucessfully








Feature: Validate SignIn Functionality

Scenario Outline: Testing the SignIn on website 
	Given Launch Chrome 
	And Navigate to login Page
	And Click on SignIn button
	Then enter <username> and <password>
	And Click on Login Button
	Then error will be visible and browser should close
Examples: 
| username				 | password |
|						 |          |
|                        | 123456   |
| deepanshunda@gmail.com |          |
| deepanshunda@gmail.com | 123456   |
Feature: Check working of API Task One on reqre.in
 
	Scenario Outline: Sucessful registration
	Given the Address of the website
	When I perform POST request on the given address <Request> and pass the  Email <Email> and enter Password <Password>
	Then I get as output the response code <ResponseCode>, token <Token> and the id <Id>
   
	Examples: 
	| Request       | Email              | Password | ResponseCode | Token             | Id |
	| /api/register | eve.holt@reqres.in | pistol   | 200          | QpwL5tke4Pnpja7X4 | 4  |

Feature: Check the working of API for second task on reqres.in
	
	Scenario Outline: Unsucessful registration task2
	Given Address of the registration API on the website for task2 
	When I perform the POST operation request on address <Request> and give the payload Email <Email>
	Then I get the output response code <ResponseCode> and output response <Response> 
   
	Examples: 
	| Request       | Email       | ResponseCode | Response         |
	| /api/register | sydney@fife | 400          | Missing password |
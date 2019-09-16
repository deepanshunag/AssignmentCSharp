Feature: Check working of API task three on reqres.in website

	Scenario Outline: List users task three
	Given Address of the registration is entered
	When I perform the GET request on address <Request> and entered with no payload
	Then I should get the response code <ResponseCode>, pagenumber <PageNumber>,  total no of users <TotalUsers> and no of users on page as <UserOnPage> 
   
	Examples: 
	| Request           | ResponseCode | PageNumber | TotalUsers | UserOnPage |
	| /api/users?page=2 | 200          | 2          | 12         | 2          |
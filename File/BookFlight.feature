Feature: Validation of price and details Searching the flight for 3 Trips
  
   Scenario Outline: Search the Flight
   Given go to expedia website
   And select multiflight option
   When I search the flight between airports <FIRST>, <SECOND>, <THIRD> on dates <Date1>, <Date2>, <Date3> for <N> Adults
   And click on search flight
   Then The Total price should be equal to <N> multiplied by price of single person
   And Trip details as FirstTrip from <Trip1from> to <Trip1to> SecondTrip from <Trip2from> to <Trip2to> ThirdTrip from <Trip3from> to <Trip3to>
   And Close all Windows of Expedia
   
	Examples: 
	|FIRST|SECOND|THIRD| Date1     | Date2      | Date3       | N | Trip1from			| Trip1to	    | Trip2from	    | Trip2to									| Trip3from								   | Trip3to          |
	| MLA | LON  | ROM | 12/12/2019 | 12/15/2019 | 12/19/2019 | 4 | Malta Intl. (MLA)   | Gatwick (LGW) | Gatwick (LGW) | Fiumicino - Leonardo da Vinci Intl. (FCO) | Fiumicino - Leonardo da Vinci Intl. (FCO)| Malta Intl. (MLA)|
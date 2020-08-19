Feature: ISW_Hotel
	Check the functionality of ISW hotel search



	Scenario: Check hotel search functionality

    Given User is on HoMepage
    When  click on hotel tab
    And Enter all the details for hotel search  
    And Click on search button of hotel
    Then User navigate to hotel listing page
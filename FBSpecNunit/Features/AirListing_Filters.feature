Feature: AirListing_Filters
 Verify all the filters of flight listing page

 Background: 
 Given User is On HomePage 
    And  Enter all the details of ISW 

    | Source | Destination | DeptDate   | ReturnDate | Adult | Class    |
    | LAX    | NYC         | 09/20/2020 | 09/25/2020 | 2     | Business |
    And  Click on search button
    And  User is navigated to listing page

   
  Scenario: Verify flight times Going filter
#    Given User is On HomePage 
#    And  Enter all the details of ISW 
#
#    | Source | Destination | DeptDate   | ReturnDate | Adult | Class    |
#    | LAX    | NYC         | 09/20/2020 | 09/25/2020 | 2     | Business |
#
#    And  Click on search button
#    And  User is navigated to listing page
    When Click on going slider from left    
    Then Going Slider selected time will appear in the contract


    Scenario: Verify flight times Return filter
#    Given User is On HomePage 
#    And  Enter all the details of ISW 
#
#    | Source | Destination | DeptDate   | ReturnDate | Adult | Class    |
#    | LAX    | NYC         | 09/20/2020 | 09/25/2020 | 2     | Business |
#
#    And  Click on search button
#    And  User is navigated to listing page
    When Click on return slider from left    
    Then Return Slider selected time will appear in the contract
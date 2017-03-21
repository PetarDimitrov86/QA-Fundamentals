Feature: Filter (Taken from Use Case)
As a user, I want to filter so that I can limit what products are shown.

Background: Navigate to filter
  Given I navigate to home page
  And I select category "Women"

Scenario: User is able to filter products only by max price
  //Given I navigate to home page
  //And I select category "Women"
  When I slide the "Lowest price" bar to the max value
  Then I should see results filtered by max price
  
  Scenario: User is able to slide back from Highest price
  When I slide the "Lowest price" bar to the max value
  Then I should be able to slide back the "Lowest price" bar to its leftmost position
Feature: BingSearch
	As a User I want to check the Bing search service functionality

@BingSearch
Scenario: Verify the search functionality of bing search Page
	Given I navigated to the page "http://www.bing.com/"
	And I see page was loaded
	#When I enter search keyword in search Testbox
	#| Keyword |
	#| Testing |
	#And I click search button
	#Then I should see search keyword related results

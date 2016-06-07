Feature: GoogleSearch
	As a User I want to check the Google serach service
	

@GoogleSearch
Scenario: Verify the search functionality of google search Page
	Given I navigate to the page "https://www.google.co.in/?gfe_rd=cr&ei=DGlUV_7bOLDv8wfDt6CYAw"
	And I see page is loaded
	#When I enter search keyword in search Testbox
	#| Keyword |
	#| Testing |
	#And I click search button
	#Then I should see search keyword related results
	
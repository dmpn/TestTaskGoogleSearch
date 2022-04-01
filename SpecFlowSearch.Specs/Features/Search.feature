Feature: Search
![Search]()
Simple calculator for adding **two** numbers

Link to a feature: [Search]($projectname$/Features/Search.feature)

@mytag
Scenario: Search keyword
	Given I have entered the Google Home page
	And I have entered Automation into google search bar
	When I press search button	
	Then the result should be a new pages with results for Automation
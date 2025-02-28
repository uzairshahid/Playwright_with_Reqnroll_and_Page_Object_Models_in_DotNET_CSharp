Feature: LoginPageTests

A short summary of the feature

@AdminLoginFeature
Scenario: To Verify, Admin should be able to login with correct Username And Password
	Given Go to Admin Login Page with URL "<PageNavigationRoute>"
	#Given Go to Admin Login Page with URL
	When Enter Correct UserName "<username>" and Password "<password>"
	Then Click on the Login Button

	Examples:
      | username  | password    | PageNavigationRoute|
      | Admin | admin123 | /auth/login|

	



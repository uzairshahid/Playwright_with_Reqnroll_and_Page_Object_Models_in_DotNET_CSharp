Feature: Add Employee Test
#
#Background: 
#	Given Go to Admin Login Page with URL "<PageNavigationRoute>"
#	When Enter Correct UserName "<username>" and Password "<password>"
#	Then Click on the Login Button





@AddEmployeeFeature
Scenario: To Verify, Admin should be able to Create Employe by login and then go to create Employe Page
	Given Go to Admin Login Page with URL "<PageNavigationRoute>"
	When Enter Correct UserName "<username>" and Password "<password>"
	Then Click on the Login Button
	And Then go to PIM Page
	And Click on Add Employe Button
	And Enter Correct First Name "<FirstName>", Middle Name"<MiddleName>", Last Name "<LastName>", Employee ID "<EmployeeId>"
	#And Make Create Login Details As Disabled
	Then Click on the Save Button
	Then Click on the Personal Details Button
	Then Enter Driver's License Number "<DriverLicenseNumber>", License Expiry Date "<DriverLicenseExpiryDay>" "<DriverLicenseExpiryMonth>" "<DriverLicenseExpiryYear>", Nationality "<Nationality>",Marital Status "<MaritalStatus>", Date of Birth "<DateOfBirthDay>" "<DateOfBirthMonth>" "<DateOfBirthYear>", Gender "<Gender>"
	#And Enter Driver's License Number "<DriverLicenseNumber>"
	Then Click on the Save Button Add Details


	




	Examples:
      | username | password | PageNavigationRoute | FirstName | MiddleName | LastName | DriverLicenseExpiryDay | DriverLicenseExpiryMonth | DriverLicenseExpiryYear | Nationality | MaritalStatus | DateOfBirthDay | DateOfBirthMonth | DateOfBirthYear | Gender |
      | Admin    | admin123 | /auth/login         | Uz		  | Ai         | R        | 15                     | December                 | 2023                    | Qatari      | Married       | 5              | August           | 1991            | Male   |




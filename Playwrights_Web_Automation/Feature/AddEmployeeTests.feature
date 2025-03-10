@AddEmployeeFeature
Feature: Add Employee Functionality
  As an Admin, I want to add an employee so that I can manage employee details in the system.

Background:
  Given Go to Admin Login Page with URL "/auth/login"
  When Enter Correct UserName "Admin" and Password "admin123"
  Then Click on the Login Button

Scenario: To Verify, Admin should be able to Create Employee by login and then go to create Employee Page
  Given Then go to PIM Page
  When Click on Add Employee Button
  And Enter Correct First Name "<FirstName>", Middle Name "<MiddleName>", Last Name "<LastName>", Employee ID "<EmployeeId>"
  And Click on the Save Button
  Then Click on the Personal Details Button
  And Enter Driver's License Number "<DriverLicenseNumber>", License Expiry Date "<DriverLicenseExpiryDay>" "<DriverLicenseExpiryMonth>" "<DriverLicenseExpiryYear>", Nationality "<Nationality>", Marital Status "<MaritalStatus>", Date of Birth "<DateOfBirthDay>" "<DateOfBirthMonth>" "<DateOfBirthYear>", Gender "<Gender>"
  Then Click on the Save Button Add Details



  Examples:
    | FirstName | MiddleName | LastName | EmployeeId | DriverLicenseNumber | DriverLicenseExpiryDay | DriverLicenseExpiryMonth | DriverLicenseExpiryYear | Nationality | MaritalStatus | DateOfBirthDay | DateOfBirthMonth | DateOfBirthYear | Gender |
    | Uz        | Ai         | R        | 122323     |       12345         |         15             | December                 | 2022                    | Qatari      | Married       | 5              | August           | 1991            | Male   |

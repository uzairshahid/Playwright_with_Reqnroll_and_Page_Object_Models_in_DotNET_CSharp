using Microsoft.Playwright;
using Playwrights_Web_Automation.Pages;
using Playwrights_Web_Automation.Utils;
using Reqnroll;

namespace Playwrights_Web_Automation.Definitions
{
    [Binding]
    public sealed class PIMPageTestsStepDefinitions
    {
        private readonly IPage _page;
        private readonly Config _config;
        private PIMPages? _pimPages;
        string randomNumber = Helpers.GetRandomUserID().ToString();

        public PIMPageTestsStepDefinitions(ScenarioContext scenarioContext)
        {
            // Retrieve the Page instance from ScenarioContext
            _page = scenarioContext["Page"] as IPage ?? throw new NullReferenceException("Page is not initialized in ScenarioContext.");

            // Retrieve the Config instance from ScenarioContext (if stored)
            _config = scenarioContext["Config"] as Config ?? throw new NullReferenceException("Config is not initialized in ScenarioContext.");
        }

        [Given("Then go to PIM Page")]
        public async Task ThenGoToPIMPage()
        {
            _pimPages = new PIMPages(_page); // Initialize _pimPages
            await _pimPages.ClickPIMButton();
            ExtentReportHelper.LogInfo("PIM Button Clicked Sucessfully.");
        }

        [When("Click on Add Employee Button")]
        public async Task WhenClickOnAddEmployeeButton()
        {
            if (_pimPages == null)
            {
                throw new NullReferenceException("_pimPages is not initialized.");
            }
            await _pimPages.ClickAddEmployeeButton();
            ExtentReportHelper.LogPass("Clicked On Add Employee Button Sucessfully.");

        }

        [When("Enter Correct First Name {string}, Middle Name {string}, Last Name {string}, Employee ID {string}")]
        public async Task ThenEnterCorrectFirstNameMiddleNameLastNameEmployeeID(string firstName, string middleName, string lastName, string employeeId)
        {
            if (_pimPages == null)
            {
                throw new NullReferenceException("_pimPages is not initialized.");
            }
            await _pimPages.AddEmployee(firstName + randomNumber, middleName + randomNumber, lastName + randomNumber, randomNumber);
            ExtentReportHelper.LogPass($"Entered First Name:{firstName + randomNumber}, Entered Middle Name:{middleName + randomNumber}, Entered Last Name:{lastName + randomNumber} And Employye Id: {randomNumber}.");

        }


        [When("Click on the Save Button")]
        public async Task ThenClickOnTheSaveButton()
        {
            if (_pimPages == null)
            {
                throw new NullReferenceException("_pimPages is not initialized.");
            }
            await _pimPages.ClickSaveEmployeeButton();
            ExtentReportHelper.LogInfo("Clicked On Save Employee Button Sucessfully.");
        }

        [When("Verify, Is User Created Sucessfully")]
        public async Task VerifyUserSavedSucessfully()
        {
            await _pimPages.IsElementVisibility();
            ExtentReportHelper.LogPass("Verified User Added Sucessfully.");


        }

        [Then("Click on the Personal Details Button")]
        public async Task ThenClickOnThePersonalDetailsButton()
        {
            if (_pimPages == null)
            {
                throw new NullReferenceException("_pimPages is not initialized.");
            }
            await _pimPages.ClickSavePersonalDetailsButton();
        }

        
        [Then("Enter Driver's License Number {string}, License Expiry Date {string} {string} {string}, Nationality {string}, Marital Status {string}, Date of Birth {string} {string} {string}, Gender {string}")]
        public async Task ThenEnterDriversLicenseNumberLicenseExpiryDateNationalityMaritalStatusDateOfBirthGender(string driverLicenseNumber, string driverLicenseExpiryDay, string driverLicenseExpiryMonth, string driverLicenseExpiryYear, string nationality, string maritalStatus, string dateOfBirthDay, string dateOfBirthMonth, string dateOfBirthYear, string gender)
        {
            if (_pimPages == null)
            {
                throw new NullReferenceException("_pimPages is not initialized.");
            }
            await _pimPages.UpdateNewEmployeeDetails(driverLicenseNumber, driverLicenseExpiryDay, driverLicenseExpiryMonth, driverLicenseExpiryYear, nationality, maritalStatus, dateOfBirthDay, dateOfBirthMonth, dateOfBirthYear, gender);
            ExtentReportHelper.LogPass($"Entered Driver License Number:{driverLicenseNumber}, Entered Driver License Expiry Date:{driverLicenseExpiryDay +'/'+driverLicenseExpiryMonth + '/' + driverLicenseExpiryYear}, Entered Nationality:{nationality}, Entered Marital Status:{maritalStatus}, Entered Date Of Birth:{dateOfBirthDay + '/' + dateOfBirthMonth + '/' + dateOfBirthYear}, Entered Gender:{gender}.");
        }


        [Then("Click on the Save Button Add Details")]
        public async Task ThenClickOnTheSaveButtonAddDetails()
        {
            if (_pimPages == null)
            {
                throw new NullReferenceException("_pimPages is not initialized.");
            }
            await _pimPages.ClickSaveEmployeePersonalDetailsButton();
            ExtentReportHelper.LogInfo("User Personal Detailed Added Sucessfully");
        }
    }
}
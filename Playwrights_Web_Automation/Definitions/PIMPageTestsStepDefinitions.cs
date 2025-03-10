using Microsoft.Playwright;
using Playwrights_Web_Automation.BrowserHook;
using Playwrights_Web_Automation.Commons;
using Playwrights_Web_Automation.Pages;
using Playwrights_Web_Automation.Utils;
using Reqnroll;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Playwrights_Web_Automation.Definitions
{
    [Binding]
    public sealed class PIMPageTestsStepDefinitions(ScenarioContext scenarioContext)
    {
        private IPage _page = BrowserHook.BrowserHooks.Page!;
        private Config? _config = BrowserHooks.Config!;
        private PIMPages? _pimPages;
        Helpers helpers = new Helpers();
        public ScenarioContext ScenarioContext { get; } = scenarioContext;

        [Then("Then go to PIM Page")]
        public async Task ThenThenGoToPIMPage()
        {
            _pimPages = new PIMPages(_page);
            await _pimPages.ClickPIMButton();
        }


        [Then("Click on Add Employe Button")]
        public async Task WhenClickOnAddEmployeButton()
        {

            await _pimPages.ClickAddEmployeeButton();
        }


        string randomNumber = Helpers.GetRandomUserID().ToString();

        [Then("Enter Correct First Name {string}, Middle Name{string}, Last Name {string}, Employee ID {string}")]
        public async Task ThenEnterCorrectFirstNameMiddleNameLastNameEmployeeID(string firstName, string middleName, string lastName, string employeeId) => await _pimPages.AddEmployee(firstName+ randomNumber, middleName + randomNumber, lastName+ randomNumber, randomNumber);


        [Then("Click on the Save Button")]
        public async Task ThenClickOnTheSaveButton()
        {
            await _pimPages.ClickSaveEmployeeButton();
            await _pimPages.IsElementVisibility();
        }





        [Then("Click on the Personal Details Button")]
        public async Task ThenClickOnThePersonalDetailsButton() => await _pimPages.ClickSavePersonalDetailsButton();

        //[Then("Enter Driver's License Number {string}, License Expiry Date {string}, Nationality {string},Marital Status {string}, Date of Birth {string}, Gender {string},Blood Type {string}")]
        //public async Task ThenEnterDriversLicenseNumberLicenseExpiryDateNationalityMaritalStatusDateOfBirthGenderBloodType(string driverLicenseNumber, string p1, string nationality, string maritalStatus, string dateOfBirth, string gender, string bloodType)
        //{
        //    throw new PendingStepException();
        //}


        //[Then("Enter Driver's License Number {string}, License Expiry Date {string}, Nationality {string},Marital Status {string}, Date of Birth {string}, Gender {string}")]
        //public async Task ThenEnterDriversLicenseNumberLicenseExpiryDateNationalityMaritalStatusDateOfBirthGenderBloodType(string driverLicenseNumber)
        //{
        //    await _pimPages.UpdateNewEmployeeDetails(driverLicenseNumber = randomNumber, "11","December","1988","Welsh","Single", "8", "August", "2000", "Female");
        //}


        [Then("Enter Driver's License Number {string}, License Expiry Date {string} {string} {string}, Nationality {string},Marital Status {string}, Date of Birth {string} {string} {string}, Gender {string}")]
        public async Task ThenEnterDriversLicenseNumberLicenseExpiryDateNationalityMaritalStatusDateOfBirthGender(string driverLicenseNumber, string driverLicenseExpiryDay, string driverLicenseExpiryMonth, string driverLicenseExpiryYear, string nationality, string maritalStatus, string dateOfBirthDay, string dateOfBirthMonth, string dateOfBirthYear, string gender)
        {
            await _pimPages.UpdateNewEmployeeDetails(driverLicenseNumber = randomNumber, driverLicenseExpiryDay, driverLicenseExpiryMonth, driverLicenseExpiryYear, nationality, maritalStatus, dateOfBirthDay, dateOfBirthMonth, dateOfBirthYear, gender);
        }



        [Then("Click on the Save Button Add Details")]
        public async Task ThenClickOnTheSaveButtonAddDetails() => await _pimPages.ClickSaveEmployeePersonalDetailsButton();




    }
}
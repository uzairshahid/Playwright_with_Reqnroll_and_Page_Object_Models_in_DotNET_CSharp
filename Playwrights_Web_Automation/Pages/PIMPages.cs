using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Playwrights_Web_Automation.Pages
{
    class PIMPages
    {
        private IPage _page;
        public PIMPages(IPage page) => _page = page;

        private ILocator _buttonPIM => _page.GetByText("PIM");
        private ILocator _buttonEmployeeList => _page.GetByText("Employee List");
        private ILocator _buttonAddEmployee => _page.GetByRole(AriaRole.Button, new() { Name = "Add" });
        private ILocator _inputEmployeeFirstName => _page.GetByRole(AriaRole.Textbox, new() { Name = "First Name" });
        private ILocator _inputEmployeeMiddleName => _page.GetByRole(AriaRole.Textbox, new() { Name = "Middle Name" });
        private ILocator _inputEmployeeLastName => _page.GetByRole(AriaRole.Textbox, new() { Name = "Last Name" });
        private ILocator _inputEmployeeId => _page.Locator("form").GetByRole(AriaRole.Textbox).Nth(4);
        private ILocator _buttonSaveEmployee => _page.GetByRole(AriaRole.Button, new() { Name = "Save" });
        private ILocator _messageSucessfully => _page.Locator("#app div").Filter(new() { HasText = "Add EmployeeAccepts jpg, .png" }).Nth(2);
        private ILocator _buttonPersonalDetails => _page.GetByRole(AriaRole.Link, new() { Name = "Personal Details" });
        private ILocator _inputDrivingLicense => _page.Locator("#app > div.oxd-layout.orangehrm-upgrade-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > div > div:nth-child(2) > input");
        private ILocator _buttonDrivingLicenseExpiryDatePiecker => _page.Locator("#app > div.oxd-layout.orangehrm-upgrade-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(3) > div:nth-child(2) > div:nth-child(2) > div > div:nth-child(2) > div > div > i");
        private ILocator _buttonDrivingLicenseExpiryDateInput => _page.Locator("#app > div.oxd-layout.orangehrm-upgrade-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(3) > div:nth-child(2) > div:nth-child(2) > div > div:nth-child(2) > div > div > input");
        private ILocator _dropDownNationality => _page.Locator("#app > div.oxd-layout.orangehrm-upgrade-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(5) > div:nth-child(1) > div:nth-child(1) > div > div:nth-child(2) > div > div > div.oxd-select-text--after > i");
        private ILocator _dropDownMaritalStatus => _page.Locator("#app > div.oxd-layout.orangehrm-upgrade-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(5) > div:nth-child(1) > div:nth-child(2) > div > div:nth-child(2) > div > div > div.oxd-select-text--after > i");
        private ILocator _inputDateOfBirth => _page.Locator("#app > div.oxd-layout.orangehrm-upgrade-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(5) > div:nth-child(2) > div:nth-child(1) > div > div:nth-child(2) > div > div > input");
        private ILocator _datePickerDateOfBirth => _page.Locator("#app > div.oxd-layout.orangehrm-upgrade-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(5) > div:nth-child(2) > div:nth-child(1) > div > div:nth-child(2) > div > div > i");

        private ILocator _radioMale => _page.GetByText("Male", new() { Exact = true });
        private ILocator _radioFemale => _page.GetByText("Female", new() { Exact = true });

        public async Task ClickPIMButton()
        {
            await _buttonPIM.ClickAsync();
        }
        public async Task ClickEmployeeListButton()
        {
            await _buttonEmployeeList.ClickAsync();
        }

        public async Task ClickAddEmployeeButton()
        {
            await _buttonAddEmployee.ClickAsync();
        }

        public async Task AddEmployee(string firstName, string middleName, string lastName, string employeeId)
        {
            await _inputEmployeeFirstName.FillAsync(firstName);
            await _inputEmployeeMiddleName.FillAsync(middleName);
            await _inputEmployeeLastName.FillAsync(lastName);
            await _inputEmployeeId.FillAsync(employeeId);
        }

        public async Task ClickSaveEmployeeButton()
        {
            await _buttonSaveEmployee.ClickAsync();
        } 
        public async Task ClickSaveEmployeePersonalDetailsButton()
        {
            await _buttonSaveEmployee.First.ClickAsync();
        }

        public async Task ClickSavePersonalDetailsButton()
        {
            await _buttonPersonalDetails.ClickAsync();
        }


        public async Task IsElementVisibility()
        {

            // Check if the element is visible
            bool isVisible = await _messageSucessfully.IsVisibleAsync();

            // Assert that the element is visible
            Assert.True(isVisible, "The element should be visible.");


        }

        public async Task selectCalendatDateMonthYear(string Day, string Month, string Year)
        {

            //Console.WriteLine(DateTime.Now.ToString("===============>>>" + "dd MMMM yyyy"));
            string CurrentYear = DateTime.Now.ToString("yyyy");
            string CurrentDay = DateTime.Now.ToString("dd");
            string CurrentMonth = DateTime.Now.ToString("MMMM");
            await _buttonDrivingLicenseExpiryDatePiecker.ClickAsync();
            await _page.GetByRole(AriaRole.Listitem).Filter(new() { HasText = CurrentYear }).Locator("i").ClickAsync();
            await _page.GetByText(Year, new() { Exact = true }).ClickAsync();
            await _page.GetByRole(AriaRole.Listitem).Filter(new() { HasText = CurrentMonth }).Locator("i").ClickAsync();
            await _page.GetByText(Month).ClickAsync();
            await _page.GetByText("9", new() { Exact = true}).ClickAsync();    
        }

        public async Task setNationality(string Nationality)
        {
            await _dropDownNationality.ClickAsync();
            await _page.GetByText(Nationality, new() { Exact = true }).ClickAsync();
        }

        public async Task setMaritalStatus(string MaritalStatus)
        {
            await _dropDownMaritalStatus.ClickAsync();
            await _page.GetByText(MaritalStatus, new() { Exact = true }).ClickAsync();
        }

        public async Task setDateOfBirth(string DobDay, string DobMonth, string DobYear)
        {
            string CurrentYear = DateTime.Now.ToString("yyyy");
            string CurrentDay = DateTime.Now.ToString("dd");
            string CurrentMonth = DateTime.Now.ToString("MMMM");
            await _datePickerDateOfBirth.ClickAsync();
            await _page.GetByRole(AriaRole.Listitem).Filter(new() { HasText = CurrentYear }).Locator("i").ClickAsync();
            await _page.GetByText(DobYear, new() { Exact = true }).ClickAsync();
            await _page.GetByRole(AriaRole.Listitem).Filter(new() { HasText = CurrentMonth }).Locator("i").ClickAsync();
            await _page.GetByText(DobMonth).ClickAsync();
            await _page.GetByText(DobDay, new() { Exact = true }).ClickAsync();
        }

        public async Task setGender(string gender)
        {
            if (gender == "Male")
            {
                await _radioMale.ClickAsync();
            }
            else if (gender == "Female")
            {
                await _radioFemale.ClickAsync();
            }
        }

        public async Task UpdateNewEmployeeDetails(string drivingLicense, string LicenseExpiryDay, string LicenseExpiryMonth, string LicenseExpiryYear, string Nationality, string MaritalStatus, string DobDay, string DobMonth, string DobYear, string Gender)
        {
            await _inputDrivingLicense.FillAsync(drivingLicense);
            await selectCalendatDateMonthYear(LicenseExpiryDay, LicenseExpiryMonth, LicenseExpiryYear);
            await setNationality(Nationality);
            await setMaritalStatus(MaritalStatus);
            await setDateOfBirth(DobDay, DobMonth, DobYear);
            await setGender(Gender);
        }

    }   

}

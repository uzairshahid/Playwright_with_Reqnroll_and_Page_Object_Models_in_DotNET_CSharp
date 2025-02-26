using Microsoft.Playwright;
using Playwrights_Web_Automation.Commons;
using Playwrights_Web_Automation.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Pages
{
    public class AdminPage
    {
        private IPage _page;
        public AdminPage(IPage page) => _page = page;

        private ILocator GetButtonLocator(AriaRole role, string name, bool exact = true)
        {
            return _page.GetByRole(role, new() { Name = name, Exact = exact });
        }
        private ILocator _buttonAddUsers => _page.GetByRole(AriaRole.Button, new() { Name = "Add" });
        //private ILocator _selectUserRoleOption => _page.GetByText("-- Select --");
        private ILocator _selectUserRoleOption => _page.GetByText("-- Select --");

        private ILocator _selectAdminUserRoleOption => _page.GetByRole(AriaRole.Option, new() { Name = "Admin" });
        private ILocator _selectESSUserRoleOption => _page.GetByRole(AriaRole.Option, new() { Name = "ESS" });
        private ILocator _inputEmployeeName => _page.GetByRole(AriaRole.Textbox, new() { Name = "Type for hints..." });
        private ILocator _selectEmployeeName => _page.GetByRole(AriaRole.Option, new() { Name = "Uzair Shahid" });

    private ILocator _selectStatus => _page.GetByText("-- Select --");
        private ILocator _selectStatusAsEnabled => _page.GetByRole(AriaRole.Option, new() { Name = "Enabled" });
        private ILocator _selectStatusAsDisabled => _page.GetByRole(AriaRole.Option, new() { Name = "Disabled" });

        private ILocator _inputUserName => _page.GetByRole(AriaRole.Textbox).Nth(2);
        private ILocator _inputUserPassword => _page.GetByRole(AriaRole.Textbox).Nth(3);
        private ILocator _inputUserReTypePassword => _page.GetByRole(AriaRole.Textbox).Nth(4);
        private ILocator _buttonSaveUsers => _page.GetByRole(AriaRole.Button, new() { Name = "Save" });




    public async Task ClickButton(String ButtonName)
        {
            await GetButtonLocator(AriaRole.Link, ButtonName, true).ClickAsync();
        }


        public async Task AddUser(string UserRole, string EmployeeNameInitials, string EmployeeStatus, string EmployeeUserName, string EmployeePassword)
        {
            {
                await ClickButton("Admin");
                await _buttonAddUsers.ClickAsync();

                await _selectUserRoleOption.First.ClickAsync();
                if (UserRole == "Admin")
                {
                    await _selectAdminUserRoleOption.ClickAsync();
                }
                else if (UserRole == "ESS")
                {
                    await _selectESSUserRoleOption.ClickAsync();
                }
                await _inputEmployeeName.FillAsync(EmployeeNameInitials);
                await _selectEmployeeName.ClickAsync();
                await _selectStatus.First.ClickAsync();
                if (EmployeeStatus == "Enabled")
                {
                    await _selectStatusAsEnabled.ClickAsync();
                }
                else if(EmployeeStatus =="Disabled")
                {
                    await _selectStatusAsDisabled.ClickAsync();
                }
                await _inputUserName.FillAsync(EmployeeUserName);
                await _inputUserPassword.FillAsync(EmployeePassword);
                await _inputUserReTypePassword.FillAsync(EmployeePassword);
                await _buttonSaveUsers.ClickAsync();
                await  _page.WaitForTimeoutAsync(160000); 
            }
        }


       


    }





}


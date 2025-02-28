using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Pages
{
    public class LoginPage
    {
        private IPage _page;
        public LoginPage(IPage page) => _page = page;

        private ILocator _textUserName => _page.GetByRole(AriaRole.Textbox, new() { Name = "Username" });
        private ILocator _textPassword => _page.GetByRole(AriaRole.Textbox, new() { Name = "Password" });
        private ILocator _buttonLogin => _page.Locator("button", options: new PageLocatorOptions { HasTextString = "Login" });
        private ILocator _buttonDashboard => _page.GetByRole(AriaRole.Link, new PageGetByRoleOptions() { Name = "Dashboard" });
      private ILocator ButtonDashboard (AriaRole role, string name, bool exact = true)
        {
            return _page.GetByRole(role, new() { Name = name, Exact = exact });
        }
        
        
        private ILocator _LabelDashboard => _page.GetByRole(AriaRole.Heading, new() { Name = "Dashboard" });


    public async Task NavigateToLoginPage(string URL)
        {

            await _page.GotoAsync(URL);
        }

        public async Task Login(string username, string password)
        {
            await _textUserName.FillAsync(username);
            await _textPassword.FillAsync(password);
            //await _buttonLogin.ClickAsync();
        }
        
        public async Task ClickLoginButton()
        {
            await _buttonLogin.ClickAsync();

        }


        //public async Task<bool> IsDashboardPageExists() => await _buttonDashboard.IsVisibleAsync();
        public async Task<bool> IsDashboardPageExists() => await ButtonDashboard(AriaRole.Link,"Dashboard",true).IsVisibleAsync();

       
    }
}

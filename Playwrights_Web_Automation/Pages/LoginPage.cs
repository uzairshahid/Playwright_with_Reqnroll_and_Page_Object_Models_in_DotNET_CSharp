using Microsoft.Playwright;
using Playwrights_Web_Automation.Utils;
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
        
        // Locators for elements on the page
        private ILocator _textUserName => _page.GetByRole(AriaRole.Textbox, new() { Name = "Username" });
        private ILocator _textPassword => _page.GetByRole(AriaRole.Textbox, new() { Name = "Password" });
        private ILocator _buttonForgotPassword => _page.GetByText("Forgot your password?");
        private ILocator _buttonResetForgotPassword => _page.GetByRole(AriaRole.Button, new() { Name = "Reset Password" });
        private ILocator _buttonLogin => _page.Locator("button", options: new PageLocatorOptions { HasTextString = "Login" });
        private ILocator _textResetPasswordMessage => _page.GetByRole(AriaRole.Heading, new() { Name = "Reset Password link sent" });
       
        
        
        public async Task NavigateToLoginPage(string URL)
        {
            await _page.GotoAsync(URL);
        }
        

        public async Task Login(string username, string password)
        {
            await EnterUserName(username);
            await _textPassword.FillAsync(password);
        }
        
        public async Task ClickLoginButton()
        {
            await _buttonLogin.ClickAsync();
        }
        
        public async Task EnterUserName(string UserName)
        {
            await _textUserName.FillAsync(UserName);
        }
        public async Task ClickForgotPasswordButton()
        {
            await _buttonForgotPassword.ClickAsync();
        }

        public async Task EnterUserNameForRestPassword(string UserName)
        {
            await EnterUserName(UserName);
            await _buttonResetForgotPassword.ClickAsync();
            await ClickForgotPasswordButton();
            await _textResetPasswordMessage.IsVisibleAsync();
        }       

        public async Task PageToNavigate(string url)
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();
            await page.GotoAsync(url);

        }
    }
}

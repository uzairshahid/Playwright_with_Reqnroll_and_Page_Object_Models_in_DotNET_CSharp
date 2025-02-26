using Microsoft.Playwright;
using Playwrights_Web_Automation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Base
{
    public static class AuthSetup
    {
        public static async Task SaveAuthStateAsync()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            // Perform login
            await page.GotoAsync(ConfigurationManager.BaseUrl);
            var loginPage = new LoginPage(page);
            await loginPage.Login(ConfigurationManager.Username, ConfigurationManager.Password);

            // Save authentication state to a file
            await context.StorageStateAsync(new BrowserContextStorageStateOptions
            {
                Path = "auth-state.json"
            });

            // Clean up
            await browser.CloseAsync();
            //await playwright.DisposeAsync();
        }
    }
}

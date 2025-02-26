using Microsoft.Playwright;
using Playwrights_Web_Automation.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Pages
{
    public class DashboardPage 
    {
        private IPage _page; 
        public DashboardPage(IPage page) => _page = page;

        private ILocator GetButtonLocator(AriaRole role, string name, bool exact = true)
        {
            return _page.GetByRole(role, new() { Name = name, Exact = exact });
        }


        public async Task ClickButton(String ButtonName)
        {
            await GetButtonLocator(AriaRole.Link, ButtonName, true).ClickAsync();
        }


    }
}

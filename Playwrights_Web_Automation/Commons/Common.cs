using Microsoft.Playwright;
using Playwrights_Web_Automation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Commons
{
    public class Common
    {
        //private IPage _page;

        private readonly IPage _page;
        public Common(IPage page)
        {
            _page = page;
        }


        private ILocator GetButtonLocator(AriaRole role, string name, bool exact = true)
        {
            return _page.GetByRole(role, new() { Name = name, Exact = exact });
        }



        public async Task WaitForElementToVisibleByElementText(string elementText)
        {
            await _page.WaitForSelectorAsync($"text={elementText}", new() { State = WaitForSelectorState.Visible });
        }

        public async Task WaitForElementToVisibleByElementSelector()
        {
            await _page.WaitForSelectorAsync("role=heading[name='Dashboard']", new() { State = WaitForSelectorState.Visible });
        
        }
       

        public async Task IsButtonVisible(String ButtonName)
        {
            await GetButtonLocator(AriaRole.Link, ButtonName, true).IsVisibleAsync();
        }

    }
}

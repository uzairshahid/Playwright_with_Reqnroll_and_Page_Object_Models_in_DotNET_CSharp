using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Commons
{
    public class Common
    {
        private IPage _page;
        
        public Common(IPage page) => _page = page;
        public async Task waitForElementToVisibleByElementText(String ElementText)
        {
            await _page.WaitForSelectorAsync($"text={ElementText}", new() { State = WaitForSelectorState.Visible });
        }
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

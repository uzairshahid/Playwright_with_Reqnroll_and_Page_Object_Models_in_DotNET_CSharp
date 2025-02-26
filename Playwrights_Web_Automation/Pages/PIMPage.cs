using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Pages
{
    public class PIMPage
    {
        private IPage _page;
        public PIMPage(IPage page) => _page = page;


        private ILocator _textUserName => _page.GetByRole(AriaRole.Textbox, new() { Name = "Username" });
    }
}

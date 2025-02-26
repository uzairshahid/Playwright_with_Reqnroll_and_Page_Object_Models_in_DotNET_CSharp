using Playwrights_Web_Automation.Base;
using Playwrights_Web_Automation.Model;
using Playwrights_Web_Automation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Tests
{
    public class PIMPageTests : BaseTest
    {

        [Test, Order(2)]
        public async Task VisitAdminPage()
        {
            DashboardPage dashboardPage = new DashboardPage(Page);
            await dashboardPage.ClickButton("PIM");
        }

    }
}

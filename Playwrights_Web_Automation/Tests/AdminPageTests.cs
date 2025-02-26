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
    public class AdminPageTests : BaseTest
    {
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
        AdminPage? admin;

        [Test, Order(1)]
        public async Task VisitAdminPage()
        {
            DashboardPage dashboardPage = new DashboardPage(Page);
            await dashboardPage.ClickButton("Admin");
        }

        [Test]
        [Category("addUser")]
         public async Task AddUser()
        {
            admin = new AdminPage(Page);
            await admin.AddUser("Admin","Uzair", "Enabled", $"UzairShahid {GetRandomNumber(100,10000)}", "John123456");
        }

    }


}

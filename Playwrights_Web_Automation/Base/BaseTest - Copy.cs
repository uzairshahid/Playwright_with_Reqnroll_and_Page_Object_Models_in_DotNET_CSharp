//using Microsoft.Playwright.NUnit;
//using Playwrights_Web_Automation.Commons;
//using Playwrights_Web_Automation.Model;
//using Playwrights_Web_Automation.Pages;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Playwrights_Web_Automation.Base
//{
//    public class BaseTest : PageTest
//    {

//        LoginPage? loginPage;
//        Common? commons;

//        [SetUp]
//        public async Task Setup()
//        {
//            await Page.GotoAsync(ConfigurationManager.BaseUrl);
//            loginPage = new LoginPage(Page);
//            commons = new Common(Page);
//            await loginPage.Login(ConfigurationManager.Username, ConfigurationManager.Password);
//            await commons.waitForElementToVisibleByElementText("Dashboard");
//            var isExists = await loginPage.IsDashboardPageExists();
//            Assert.IsTrue(isExists);
//        }


//        [TearDown]
//        public async Task TearDown()
//        {
//            // Add any cleanup logic here (if needed)
//            await Page.CloseAsync();
//        }



//    }
//}

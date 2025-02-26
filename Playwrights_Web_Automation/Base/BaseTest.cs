using Microsoft.Playwright.NUnit;
using Playwrights_Web_Automation.Commons;
using Playwrights_Web_Automation.Pages;


namespace Playwrights_Web_Automation.Base
{
    public class BaseTest : PageTest
    {

        LoginPage? loginPage;
        Common? commons;

        [SetUp]
        public async Task Setup()
        {
            await Page.GotoAsync(ConfigurationManager.BaseUrl);
            loginPage = new LoginPage(Page);
            commons = new Common(Page);
            await loginPage.Login(ConfigurationManager.Username, ConfigurationManager.Password);
            await commons.waitForElementToVisibleByElementText("Dashboard");
            var isExists = await loginPage.IsDashboardPageExists();
            Assert.IsTrue(isExists);
        }


        [TearDown]
        public async Task TearDown()
        {
            await Page.CloseAsync();
        }



    }
}

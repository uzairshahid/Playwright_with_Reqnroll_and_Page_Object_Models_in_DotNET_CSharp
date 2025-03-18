using Microsoft.Playwright;
using Playwrights_Web_Automation.BrowserHook;
using Playwrights_Web_Automation.Commons;
using Playwrights_Web_Automation.Pages;
using Playwrights_Web_Automation.Utils;
using Reqnroll;
using System.Security.Policy;

namespace Playwrights_Web_Automation.Definitions
{


    [Binding]
    public sealed class LoginPageTestsStepDefinitions
    {
        private readonly IPage _page;
        private readonly Config _config;
        private LoginPage? _loginPage;

        public LoginPageTestsStepDefinitions(ScenarioContext scenarioContext)
        {
            // Retrieve the Page instance from ScenarioContext
            _page = scenarioContext["Page"] as IPage ?? throw new NullReferenceException("Page is not initialized in ScenarioContext.");

            // Retrieve the Config instance from ScenarioContext (if stored)
            _config = scenarioContext["Config"] as Config ?? throw new NullReferenceException("Config is not initialized in ScenarioContext.");
        }

        [Given("Go to Admin Login Page with URL {string}")]
        public async Task GivenGoToAdminLoginPageWithURL(string pageNavigationRoute)
        {
            await _page.GotoAsync(_config!.url! + pageNavigationRoute);
            _loginPage = new LoginPage(_page);
            ExtentReportHelper.LogInfo($"Navigated to URL: {_config!.url! + pageNavigationRoute}");

        }

        [When("Enter Correct UserName {string} and Password {string}")]
        public async Task WhenEnterCorrectUserNameAndPassword(string p0, string p1)
        {
            await _loginPage.Login(p0, p1);
            ExtentReportHelper.LogInfo($"Entered username: {p0} and password: {p1}");
            

        }


        [Then("Click on the Login Button")]
        public async Task ThenClickOnTheLoginButton()
        {
            await _loginPage.ClickLoginButton();
            ExtentReportHelper.LogPass("Login button clicked successfully.");

        }

    }
}

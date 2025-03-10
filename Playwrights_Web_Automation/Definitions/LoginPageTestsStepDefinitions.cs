using Microsoft.Playwright;
using Playwrights_Web_Automation.BrowserHook;
using Playwrights_Web_Automation.Commons;
using Playwrights_Web_Automation.Pages;
using Playwrights_Web_Automation.Utils;
using Reqnroll;

namespace Playwrights_Web_Automation.Definitions
{


    [Binding]
    public sealed class LoginPageTestsStepDefinitions(ScenarioContext scenarioContext)
    {
        private IPage _page = BrowserHook.BrowserHooks.Page!;
     
        private Config? _config = BrowserHooks.Config!;
        private LoginPage? _loginPage;
       

        public ScenarioContext ScenarioContext { get; } = scenarioContext;

        [Given("Go to Admin Login Page with URL {string}")]
        public async Task GivenGoToAdminLoginPageWithURL(string pageNavigationRoute)
        {
            await _page.GotoAsync(_config!.url! + pageNavigationRoute);
            _loginPage = new LoginPage(_page);
        }

        [When("Enter Correct UserName {string} and Password {string}")]
        public async Task WhenEnterCorrectUserNameAndPassword(string p0, string p1)
        {
            await _loginPage.Login(p0, p1);
        }


        [Then("Click on the Login Button")]
        public async Task ThenClickOnTheLoginButton()
        {
            await _loginPage.ClickLoginButton();
        }

    }
}

using System;
using Allure.Commons;
using NUnit.Framework;
using Microsoft.Playwright;
using Playwrights_Web_Automation.Base;
using Playwrights_Web_Automation.Commons;
using Playwrights_Web_Automation.Model;
using Playwrights_Web_Automation.Pages;
using Reqnroll;
using NUnit.Allure.Attributes;
using Playwrights_Web_Automation.Utils;
using Playwrights_Web_Automation.BrowserHook;

namespace Playwrights_Web_Automation.Definitions
{


    [Binding]
    public sealed class LoginPageTestsStepDefinitions(ScenarioContext scenarioContext)
    {
        private IPage _page = BrowserHook.BrowserHooks.Page!;
        private string? _username;
        private string? _password;
        private Config? _config = BrowserHooks.Config!;
        private LoginPage? _loginPage;
        private AdminPage? _adminPage;
        private DashboardPage? _dashboardPage;
        private Common? commons;

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
            _dashboardPage = new DashboardPage(_page);
            await _loginPage.Login(p0, p1);
            await _loginPage.ClickLoginButton();
        }


        [Then("Click on the Login Button")]
        public async Task ThenClickOnTheLoginButton()
        {
            await _dashboardPage.ClickButton("Leave");
            await _dashboardPage.ClickButton("Time");
        }

    }
}

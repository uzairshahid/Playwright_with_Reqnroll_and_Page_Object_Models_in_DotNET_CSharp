using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using Playwrights_Web_Automation.Base;
using Playwrights_Web_Automation.Commons;
using Playwrights_Web_Automation.Model;
using Playwrights_Web_Automation.Pages;

namespace Playwrights_Web_Automation;

//[Parallelizable(ParallelScope.Self)]
public class NUnitPlaywrightsPOM : BaseTest
{
    //[SetUp]
    //public async Task Setup()
    //{
    //    await Page.GotoAsync(ConfigurationManager.BaseUrl);
    //}

    //[Test]
    //[TestCaseSource(nameof(Login))]
    //public async Task Test1(LoginPageModels login)
    //{
    //    LoginPage loginPage = new LoginPage(Page);
    //    DashboardPage dashboardPage = new DashboardPage(Page);
    //    Common commons = new Common(Page);
    //    await loginPage.Login(login.UserName, login.Password);
    //    await commons.waitForElementToVisibleByElementText("Dashboard");
    //    var isExists = await loginPage.IsDashboardPageExists();
    //    Assert.IsTrue(isExists);
    //    await dashboardPage.ClickButton("Admin");
    //    await dashboardPage.ClickButton("PIM");
    //   // await dashboardPage.ClickButton("Leave");
    //   // await dashboardPage.ClickButton("Time");
    //   // await dashboardPage.ClickButton("Recruitment");
    //   // await dashboardPage.ClickButton("My Info");
    //   // await dashboardPage.ClickButton("Performance");
    //   // await dashboardPage.ClickButton("Dashboard");
    //   // await dashboardPage.ClickButton("Directory");
    //   // await dashboardPage.ClickButton("Claim");
    //   //await dashboardPage.ClickButton("Buzz");
        

    //}

    //public static IEnumerable<LoginPageModels> Login()
    //{
    //    yield return new LoginPageModels()
    //    {
    //        UserName = ConfigurationManager.Username,
    //        Password = ConfigurationManager.Password
    //    };
    //}
}

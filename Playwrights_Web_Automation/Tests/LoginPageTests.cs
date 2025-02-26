//using Playwrights_Web_Automation.Base;
//using Playwrights_Web_Automation.Commons;
//using Playwrights_Web_Automation.Model;
//using Playwrights_Web_Automation.Pages;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Playwrights_Web_Automation.Tests
//{
//    public class LoginPageTests : BaseTest
//    {
//        LoginPage? loginPage;
//        Common? commons;

//        [Test,Order(1)]
//        [TestCaseSource(nameof(Login))]
//        public async Task LoginAdmin(LoginPageModels login)
//        {
//            loginPage = new LoginPage(Page);
//            commons = new Common(Page);
//            await loginPage.Login(login.UserName, login.Password);
//            await commons.waitForElementToVisibleByElementText("Dashboard");
//            var isExists = await loginPage.IsDashboardPageExists();
//            Assert.IsTrue(isExists);
//            // await dashboardPage.ClickButton("Leave");
//            // await dashboardPage.ClickButton("Time");
//            // await dashboardPage.ClickButton("Recruitment");
//            // await dashboardPage.ClickButton("My Info");
//            // await dashboardPage.ClickButton("Performance");
//            // await dashboardPage.ClickButton("Dashboard");
//            // await dashboardPage.ClickButton("Directory");
//            // await dashboardPage.ClickButton("Claim");
//            //await dashboardPage.ClickButton("Buzz");


//        }

//        public static new IEnumerable<LoginPageModels> Login()
//        {
//            yield return new LoginPageModels()
//            {
//                UserName = ConfigurationManager.Username,
//                Password = ConfigurationManager.Password
//            };
//        }

     
//    }
//}

//using Microsoft.Playwright;
//using Microsoft.Playwright.NUnit;
//using NUnit.Framework;


//namespace Playwrights_Web_Automation;

////[Parallelizable(ParallelScope.Self)]
//public class NUnitPlaywrights : PageTest
//{
//    [SetUp]
//    public async Task Setup()
//    {
//        await Page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login" );
//        // demos.telerik.com website
//        //await Page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login",new PageGotoOptions   // this technique will wait to perform test until dom fully loaded
//        //{
//        //    WaitUntil = WaitUntilState.DOMContentLoaded
//        //});
//    }

//    [Test]
//    public async Task Test1()
//    {

//        //await Page.FillAsync("xpath=//input[@name='username']", "Admin");
//        var userName_Input = Page.Locator("xpath=//input[@name='username']");
//        await userName_Input.FillAsync("Admin");

//        //await Page.FillAsync("xpath=//input[@name='password']", "admin123");
//        var password_Input = Page.Locator("xpath=//input[@name='password']");
//        await password_Input.FillAsync("admin123");

//        //await Page.ClickAsync("xpath =//button[contains(.,'Login')]");
//        //var login_Button = Page.Locator("xpath =//button[contains(.,'Login')]");
//        var login_Button = Page.Locator("button", new PageLocatorOptions { HasTextString = "Login" });  // we can find the locator by this technique as well 
//        await login_Button.ClickAsync();

//        await Page.WaitForTimeoutAsync(3000); 
//       await Expect(Page.Locator("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[1]/span/h6")).ToBeVisibleAsync();
//        var isExists = await Page.Locator("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[1]/span/h6").IsVisibleAsync();
//        Assert.IsTrue(isExists);
//        await Page.ScreenshotAsync(new PageScreenshotOptions
//        {
//            Path = "TestScreenShots/test.jpeg"
//        });

//    }
//}
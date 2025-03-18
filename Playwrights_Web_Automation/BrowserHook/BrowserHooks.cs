using Allure.Commons;
using Microsoft.Playwright;
using Newtonsoft.Json;
using Playwrights_Web_Automation.Base;
using Playwrights_Web_Automation.Utils;
using Reqnroll;
using System.IO;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.BrowserHook
{
    [Binding]
    public sealed class BrowserHooks
    {
        private static IBrowser? _browser; // Static to share between scenarios
        private IBrowserContext? _context;
        private IPage? _page;
        private Config? _config;
        private readonly ScenarioContext _scenarioContext;

        public BrowserHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext; // Inject ScenarioContext
        }

        [BeforeTestRun]
        public static async Task BeforeAll()
        {
            // Initialize shared resources here (if needed)
            ExtentReportHelper.GetExtentReport();
        }

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            var testName = _scenarioContext.ScenarioInfo.Title;
            ExtentReportHelper.CreateTest(testName);

            // Load config.json
            string projectRoot = Path.Combine(Directory.GetCurrentDirectory(), "../../../");
            string filePath = Path.Combine(projectRoot, "config.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("config.json file not found.");
            }

            string jsonContent = File.ReadAllText(filePath);
            _config = JsonConvert.DeserializeObject<Config>(jsonContent) ?? throw new InvalidOperationException("Failed to deserialize config.json.");

            // Store Config in ScenarioContext
            _scenarioContext["Config"] = _config;

            // Initialize browser if not already initialized
            if (_browser == null)
            {
                var baseDriver = new BaseDriver(_config.browser!);
                _browser = await baseDriver.GetBrowserAsync();

                if (_browser == null)
                {
                    throw new NullReferenceException("The browser is not initialized.");
                }
            }

            // Create a new context and page
            _context = await _browser.NewContextAsync(new BrowserNewContextOptions
            {
                ViewportSize = ViewportSize.NoViewport // Adjust as needed
            });

            _page = await _context.NewPageAsync();

            // Store the page in ScenarioContext for access in step definitions
            _scenarioContext["Page"] = _page;
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            // Take a screenshot on failure
            //if (_scenarioContext.TestError != null && _page != null)
            //{
            //    var screenshotBytes = await _page.ScreenshotAsync();
            //    AllureLifecycle.Instance.AddAttachment("Screenshot on Failure", "image/png", screenshotBytes);
            //}

            if (_scenarioContext.TestError != null && _page != null)
            {
                var screenshotBytes = await _page.ScreenshotAsync();
                var screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), "../../../TestResults/screenshot.png");
                File.WriteAllBytes(screenshotPath, screenshotBytes);

                // Attach screenshot to ExtentReport
                ExtentReportHelper.LogFail($"Test failed: {_scenarioContext.TestError.Message}");
                ExtentReportHelper.LogFail("Screenshot captured: <a href='" + screenshotPath + "'><img src='" + screenshotPath + "' height='100' width='100'/></a>");
            }
            else
            {
                ExtentReportHelper.LogPass("Test passed successfully.");
            }

            // Clean up page and context
            if (_page != null)
            {
                await _page.CloseAsync();
            }

            if (_context != null)
            {
                await _context.CloseAsync();
            }
        }

        [AfterTestRun]
        public static async Task AfterAll()
        {
            // Clean up shared resources here
            if (_browser != null)
            {
                await _browser.CloseAsync();
                _browser = null; // Reset the browser instance
                ExtentReportHelper.FlushReport();
            }
        }
    }
}
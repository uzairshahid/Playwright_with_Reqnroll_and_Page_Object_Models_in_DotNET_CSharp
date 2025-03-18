using Microsoft.Playwright;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Base
{
    public class BaseDriver
    {
        private readonly bool _isHeadless;
        private readonly string _browserType;
        private readonly Task<IBrowser> _browser;

        public BaseDriver(string browserType, bool isHeadless = false)
        {
            _browserType = browserType;
            _isHeadless = isHeadless;
            _browser = InitializePlaywright(); // Directly call the async method
        }

        public async Task<IBrowser> GetBrowserAsync()
        {
            return await _browser; // Await the task to get the browser instance
        }

        private async Task<IBrowser> InitializePlaywright()
        {
            var playwright = await Playwright.CreateAsync();
            IBrowser browser;

            switch (_browserType.ToLower()) // Use ToLower() for case-insensitive comparison
            {
                case "chromium":
                    browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                    {
                        Args = new[] { "--start-maximized" },
                        Headless = _isHeadless
                    });
                    break;
                case "firefox":
                    browser = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
                    {
                        Args = new[] { "--kiosk" },
                        Headless = _isHeadless
                    });
                    break;
                case "webkit":
                    browser = await playwright.Webkit.LaunchAsync(new BrowserTypeLaunchOptions
                    {
                        Headless = _isHeadless
                    });
                    break;
                default:
                    throw new ArgumentException($"Unsupported browser type: {_browserType}");
            }

            return browser;
        }
    }
}
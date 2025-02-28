﻿using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Base
{
   public class BaseDriver
    {
        private readonly bool _isHeadless;
        private readonly string _browserType;
        private readonly Task<IBrowser> _browser;
        public IBrowser Browser => _browser.Result;


        public BaseDriver(string browserType, bool isHeadless = false)
        {
            this._browserType = browserType;
            this._isHeadless = isHeadless;
            _browser = Task.Run(InitializePlaywright);
        }

        private async Task<IBrowser> InitializePlaywright()
        {
            var playwright = await Playwright.CreateAsync();
            IBrowser? taskIBrowser = null;

            switch (this._browserType)
            {
                case "chromium":
                    taskIBrowser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                    {
                        Args = new[] { "--start-maximized" },
                        Headless = this._isHeadless
                    });
                    break;
                case "firefox":
                    taskIBrowser = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
                    {
                        Args = new[] { "--kiosk" },
                        Headless = this._isHeadless
                    });
                    break;
                case "webkit":
                    taskIBrowser = await playwright.Webkit.LaunchAsync(new BrowserTypeLaunchOptions
                    {
                        Headless = this._isHeadless
                    });
                    break;
            }
            return taskIBrowser!;
        }
    }
}

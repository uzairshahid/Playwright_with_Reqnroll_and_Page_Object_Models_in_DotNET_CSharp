using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwrights_Web_Automation.Utils
{
    public class PageObject
    {
        private readonly IPage _page;
        public PageObject(IPage page)
        {
            _page = page;
        }

        public async Task ClickElement(string elementLocator)
        {
            await _page.Locator(elementLocator).ClickAsync();
        }


        public async Task WaitForElementBeVisible(string elementLocator)
        {
            await _page.Locator(elementLocator).WaitForAsync(new LocatorWaitForOptions
            {
                State = WaitForSelectorState.Visible
            });
        }

        public async Task WaitForElementPresent(string elementLocator)
        {
            await _page.Locator(elementLocator).WaitForAsync(new LocatorWaitForOptions
            {
                State = WaitForSelectorState.Attached
            });
        }

        public async Task WaitForElementToDisappear(string elementLocator)
        {
            await _page.Locator(elementLocator).WaitForAsync(new LocatorWaitForOptions
            {
                State = WaitForSelectorState.Hidden
            });
        }

        public async Task WaitForElementInnerTextToBe(string elementLocator, string expectedText)
        {
            int attempts = 0;
            string currentText = "";
            while (attempts < 10 && currentText != expectedText)
            {
                currentText = await _page.Locator(elementLocator).InnerTextAsync();

                if (currentText != expectedText)
                {
                    await _page.WaitForTimeoutAsync(500);
                    attempts++;
                }
            }

            if (currentText != expectedText)
            {
                throw new TimeoutException();
            }
        }

        public async Task VerifyElementInnerText(string elementLocator, string expectedText)
        {
            await Assertions.Expect(_page.Locator(elementLocator)).ToHaveTextAsync(expectedText);
        }

        public async Task VerifyElementTextValue(string elementLocator, string expectedText)
        {
            await Assertions.Expect(_page.Locator(elementLocator)).ToHaveValueAsync(expectedText);
        }

        public void VerifyTextAlert(string msg, string expectedText)
        {
            Assert.AreEqual(msg, expectedText);
        }

        public async Task EnterText(string elementLocator, string text)
        {
            await _page.Locator(elementLocator).FillAsync(text);
        }

        public async Task VerifyCurrentUrl(string expectedUrl)
        {
            await Assertions.Expect(_page).ToHaveURLAsync(expectedUrl);
        }

    }
}

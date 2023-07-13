using Coypu;
using System;

namespace SpecFlowDemo.Specs.Support
{
    /// <summary>
    /// BrowserSession helper functions for the web-based calculator.
    /// See this page for selector details: https://github.com/featurist/coypu
    /// </summary>
    public static class CalcJsExtensions
    {
        public static BrowserSession EnterNumber(this BrowserSession browserSession, int digit)
        {
            string buttonId = "button-" + digit;
            ElementScope totalInput = browserSession.FindId(buttonId);
            totalInput.Click();

            return browserSession;
        }

        public static BrowserSession SetAction(this BrowserSession browserSession, string action)
        {
            string buttonId = "button-" + action;
            ElementScope totalInput = browserSession.FindId(buttonId);
            totalInput.Click();

            return browserSession;
        }

        public static BrowserSession Calculate(this BrowserSession browserSession)
        {
            string buttonId = "button-calculate";
            ElementScope totalInput = browserSession.FindId(buttonId);
            totalInput.Click();

            return browserSession;
        }

        public static BrowserSession Clear(this BrowserSession browserSession)
        {
            string buttonId = "button-clear";
            ElementScope totalInput = browserSession.FindId(buttonId);
            totalInput.Click();

            return browserSession;
        }

        public static decimal GetTotal(this BrowserSession browserSession)
        {
            ElementScope totalInput = browserSession.FindId("total");
            string value = totalInput.Value;

            if (decimal.TryParse(value, out decimal result))
            {
                return result;
            }

            throw new InvalidOperationException("Unable to get total");
        }
    }
}

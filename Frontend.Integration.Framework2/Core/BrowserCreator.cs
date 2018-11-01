using Coypu;
using Coypu.Drivers;
using Coypu.Drivers.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Configuration;

namespace Frontend.Integration.Framework2.Core
{
    public static class BrowserCreator
    {
        public static BrowserSession GetBrowser(SessionConfiguration sessionConfiguration = null, DesiredCapabilities desiredCapabilities = null)
        {
            var browserType = ConfigurationManager.AppSettings["BrowserType"];
            Browser browser = Browser.Parse(browserType);
            BrowserSession browserSession;

            var sessionConfig = sessionConfiguration ?? new SessionConfiguration
            {
                Driver = typeof(SeleniumWebDriver),
                Browser = browser,
                Timeout = TimeSpan.FromSeconds(5)
            };

            browserSession = new BrowserSession(sessionConfig);

            //If height and width are undefined, browser window is maximized
            int width = 0, height = 0;
            bool maximizeWindow = false;

            try
            {
                width = int.Parse(ConfigurationManager.AppSettings["BrowserWidth"]);
            }

            catch (Exception)
            {
                maximizeWindow = true;
            }

            try
            {
                height = int.Parse(ConfigurationManager.AppSettings["BrowserHeight"]);
            }

            catch (Exception)
            {
                maximizeWindow = true;
            }

            if(maximizeWindow)
            {
                browserSession.MaximiseWindow();
            }

            else
            {
                browserSession.ResizeTo(width, height);
            }

            return browserSession;
        }
    }
}

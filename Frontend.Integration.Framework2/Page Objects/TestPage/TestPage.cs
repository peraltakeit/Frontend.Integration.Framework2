using Coypu;
using Frontend.Integration.Framework2.Helpers;
using System;
using System.Configuration;

namespace Frontend.Integration.Framework2.Page_Objects.TestPage
{
    public class TestPage
    {
        public BrowserSession _browser = FeatureContextWrapper.BrowserSession;

        public ElementScope SignInLink;
        public ElementScope EmailField;
        public ElementScope NextButton;
        public ElementScope WelcomeHeader;
        public ElementScope PasswordField;

        public TestPage()
        {
            SignInLink = _browser.FindLink("Sign in");
            EmailField = _browser.FindXPath("//input[@type='email']");
            NextButton = _browser.FindXPath("//span[contains(text(), 'Next')]");
            WelcomeHeader = _browser.FindXPath("//content[contains(text(), 'Welcome')]");
            PasswordField = _browser.FindXPath("//input[@type='password']");
        }

        public void NavigateTo()
        {
            _browser.Visit(ConfigurationManager.AppSettings["Url"]);
        }

        public void ClickSignInLink()
        {
            SignInLink.Click(new Options { Timeout = TimeSpan.FromSeconds(10), RetryInterval = TimeSpan.FromSeconds(1) });
        }

        public bool EmailFieldExists()
        {
            return EmailField.Exists(new Options { Timeout = TimeSpan.FromSeconds(10), RetryInterval = TimeSpan.FromSeconds(1) });
        }

        public void FillInEmailField(string email)
        {
            EmailField.FillInWith(email);
        }

        public void ClickNextButton()
        {
            NextButton.Click();
        }

        public bool WelcomeHeaderExists()
        {
            return WelcomeHeader.Exists(new Options { Timeout = TimeSpan.FromSeconds(10), RetryInterval = TimeSpan.FromSeconds(1) });
        }

        public string GetWelcomeHeaderText()
        {
            return WelcomeHeader.Text;
        }
    }
}

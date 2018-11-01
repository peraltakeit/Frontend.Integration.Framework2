using Coypu;
using TechTalk.SpecFlow;

namespace Frontend.Integration.Framework2.Helpers
{
    public class FeatureContextWrapper
    {
        public static BrowserSession BrowserSession
        {
            get { return (BrowserSession)FeatureContext.Current["BrowserSession"]; }
            set { FeatureContext.Current.Set(value, "BrowserSession"); }
        }
    }
}

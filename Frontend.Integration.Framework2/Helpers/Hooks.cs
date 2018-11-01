using Frontend.Integration.Framework2.Core;
using TechTalk.SpecFlow;

namespace Frontend.Integration.Framework2.Helpers
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario]
        public void ScenarioSetup()
        {
            FeatureContextWrapper.BrowserSession = BrowserCreator.GetBrowser();
        }

        [AfterScenario]
        public void ScenarioTearDown()
        {
            FeatureContextWrapper.BrowserSession.Dispose();
        }
    }
}

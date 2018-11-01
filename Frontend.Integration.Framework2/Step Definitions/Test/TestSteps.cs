using Frontend.Integration.Framework2.Page_Objects.TestPage;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Frontend.Integration.Framework2.Step_Definitions.Test
{
    [Binding]
    public class TestSteps
    {
        [Given(@"I am on the test page")]
        public void GivenIAmOnTheTestPage()
        {
            var testPage = new TestPage();
            testPage.NavigateTo();
        }
        
        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            var testPage = new TestPage();
            testPage.ClickSignInLink();
        }
        
        [When(@"I enter ""(.*)"" into the email field")]
        public void WhenIEnterIntoTheEmailField(string email)
        {
            var testPage = new TestPage();
            testPage.FillInEmailField(email);
        }
        
        [When(@"I click the next button")]
        public void WhenIClickTheNextButton()
        {
            var testPage = new TestPage();
            testPage.ClickNextButton();
        }
        
        [Then(@"I should be taken to the sign in page")]
        public void ThenIShouldBeTakenToTheSignInPage()
        {
            var testPage = new TestPage();
            Assert.IsTrue(testPage.EmailFieldExists(), "Email field does not exist.");
        }
        
        [Then(@"the ""(.*)"" header should be displayed")]
        public void ThenTheHeaderShouldBeDisplayed(string headerText)
        {
            var testPage = new TestPage();
            Assert.AreEqual(headerText, testPage.GetWelcomeHeaderText(), "Header text is not as expected.");
        }
    }
}

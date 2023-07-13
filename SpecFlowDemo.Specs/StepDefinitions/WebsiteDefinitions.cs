using Coypu;
using Coypu.Drivers;
using FluentAssertions;
using SpecFlowDemo.Specs.Support;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.StepDefinitions
{
    [Binding]
    public sealed class WebsiteDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly BrowserSession _browserSession;

        public WebsiteDefinitions()
        {
            var sessionConfiguration = new SessionConfiguration
            {
                AppHost = "localhost",
                Port = 7057,
                SSL = true,
                Browser = Browser.Chrome
            };

            _browserSession = new BrowserSession(sessionConfiguration);
        }

        [Given("I have browsed to the calculator page")]
        public void IHaveBrowsedToTheCalculatorPage()
        {
            _browserSession.Visit("/Calculator");
        }

        [When("The calculator is cleared")]
        public void GivenIHaveABlankCalculator()
        {
            _browserSession.Clear();
        }

        [Then(@"The calculator should be displayed")]
        public void ThenTheCalculatorShoulwBeDisplayed()
        {
            ElementScope totalInput = _browserSession.FindId("total");

            totalInput.Should().NotBeNull();
            totalInput.Value.Should().Be("0");
        }

        [When($@"A number of (.+) is entered")]
        public void WhenANumberOfXIsEntered(int digit)
        {
            _browserSession.EnterNumber(digit);
        }

        [When(@"The action is set to Add")]
        public void WhenTheActionIsSetToAdd()
        {
            _browserSession.SetAction("add");
        }

        [When(@"The action is set to Subtract")]
        public void WhenTheActionIsSetToSubtract()
        {
            _browserSession.SetAction("subtract");
        }

        [When("The result is calculated")]
        public void WhenTheResultIsCalculated()
        {
            _browserSession.Calculate();
        }

        [Then("The result should be (.+)")]
        public void ThenTheResultShouldBe(decimal expectedResult)
        {
            decimal actualResult = _browserSession.GetTotal();

            actualResult.Should().Be(expectedResult);
        }
    }
}

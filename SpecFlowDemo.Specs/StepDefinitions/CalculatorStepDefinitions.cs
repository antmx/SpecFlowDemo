using FluentAssertions;
using SpecFlowDemo.Calculator;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.StepDefinitions
{
	[Binding]
	public sealed class CalculatorStepDefinitions
	{
		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private readonly Calc _calculator;

		public CalculatorStepDefinitions(Calc calculator)
		{
			_calculator = calculator;
		}

		[Given("I have a blank calculator")]
		[StepDefinition("the calculator is cleared")]
		public void GivenIHaveABlankCalculator()
		{
			_calculator.Clear();
		}

		[When($@"the first number of (.+) is entered")]
		public void GivenTheFirstNumberIs(double number)
		{
			_calculator.EnterFirstNumber(number);
		}

		[When("the next number of (.+) is entered")]
		public void GivenTheNextNumberIs(double number)
		{
			_calculator.EnterNextNumber(number);
		}

		[When(@"the action is set to Add")]
		public void WhenTheActionIsSetToAdd()
		{
			_calculator.CurrentAction = Calc.Action.Add;
		}

		[When(@"the action is set to Subtract")]
		public void WhenTheActionIsSetToSubtract()
		{
			_calculator.CurrentAction = Calc.Action.Subtract;
		}

		[When("the result is calculated")]
		public void WhenTheResultIsCalculated()
		{
			_calculator.Calculate();
		}

		[Then("the result should be (.+)")]
		public void ThenTheResultShouldBe(double expectedResult)
		{
			double actualResult = _calculator.Total;

			actualResult.Should().Be(expectedResult);
		}
	}
}

using FluentAssertions;
using SpecFlowDemo.Calculator;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.StepDefinitions
{
	[Binding]
	public sealed class CalculatorStepDefinitions
	{
		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private Calc _calculator;

		[Given("I have a blank calculator")]
		public void GivenIHaveANewCalculatorInstance()
		{
			_calculator = new Calc();
		}

		[Given($@"the first number is (.+)")]
		public void GivenTheFirstNumberIs(double number)
		{
			_calculator.EnterFirstNumber(number);
		}

		[Given("the second number is (.+)")]
		[Given("the next number is (.+)")]
		public void GivenTheSecondNumberIs(double number)
		{
			_calculator.EnterFurtherNumber(number);
		}

		[When("the two numbers are added")]
		public void WhenTheTwoNumbersAreAdded()
		{
			// Implement act (action) logic

			_calculator.Calculate(Calc.Action.Add);
		}

		[Then("the result should be (.+)")]
		public void ThenTheResultShouldBe(double expectedResult)
		{
			// Implement assert (verification) logic

			double actualResult = _calculator.Total;

			actualResult.Should().Be(expectedResult);
		}
	}
}

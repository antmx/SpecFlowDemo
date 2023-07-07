namespace SpecFlowDemo.Calculator
{
	public class Calc
	{
		public enum Action { Add, Subtract };

		private double _total;
		private double _furtherNumber;

		public void EnterFirstNumber(double number)
		{
			_total = number;
		}

		public void Calculate(Action action)
		{
			switch (action)
			{
				case Action.Add:
					Add(_furtherNumber);
					break;

				case Action.Subtract:
					Subtract(_furtherNumber);
					break;
			}
		}

		public void EnterFurtherNumber(double number)
		{
			_furtherNumber = number;
		}

		private void Add(double number)
		{
			_total += number;
		}

		private void Subtract(double number)
		{
			_total -= number;
		}

		public double Total
		{
			get { return _total; }
		}
	}
}

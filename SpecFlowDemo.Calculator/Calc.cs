namespace SpecFlowDemo.Calculator
{
	public class Calc
	{
		public enum Action { Add, Subtract };

		private double _total;
		private double _nextNumber;

		public void EnterFirstNumber(double number)
		{
			_total = number;
		}

		public void EnterNextNumber(double number)
		{
			_nextNumber = number;
		}

		public void Calculate(Action action)
		{
			switch (action)
			{
				case Action.Add:
					Add(_nextNumber);
					break;

				case Action.Subtract:
					Subtract(_nextNumber);
					break;
			}
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

		public void Clear()
		{
			_total = 0.0;
		}
	}
}

namespace SpecFlowDemo.Calculator
{
	public class Calc
	{
		public enum Action { None, Add, Subtract };

		private double _runningTotal;
		private double _nextNumber;

		public Action CurrentAction { get; set; } = Action.None;

		public void EnterFirstNumber(double number)
		{
			_runningTotal = number;
		}

		public void EnterNextNumber(double number)
		{
			_nextNumber = number;
		}

		public void Calculate()
		{
			switch (CurrentAction)
			{
				case Action.Add:
					Add(_nextNumber);
					break;

				case Action.Subtract:
					Subtract(_nextNumber);
					break;

				case Action.None:
					// Do nothing
					break;

				default:
					throw new InvalidOperationException($"Unexpected action: [{CurrentAction}]");
			}
		}

		private void Add(double number)
		{
			_runningTotal += number;
		}

		private void Subtract(double number)
		{
			_runningTotal -= number;
		}

		public double Total
		{
			get { return _runningTotal; }
		}

		public void Clear()
		{
			_runningTotal = 0.0;
		}
	}
}

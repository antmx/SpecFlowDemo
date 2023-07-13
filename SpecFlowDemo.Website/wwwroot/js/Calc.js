
/**
 * Performs numeric calculations.
 */
let Calc = (function () {

    let _runningTotal = 0;
    let _nextNumber = 0;
    let _currentAction = ""

    /**
     * ctor
     */
    function Calc() {
      // this is whats is returned when we do: let _calc = new Calc();
    }

    Calc.prototype.CurrentAction = function (action) {

        if (action === undefined) {
            return _currentAction;
        }
        else {
            _currentAction = action?.toLowerCase();
        }
    }

    Calc.prototype.EnterNumber = function (number) {

        number = parseFloat(number);

        if (!isNaN(number)) {
            if (!_currentAction) {
                _runningTotal = number;
            }
            else {
                _nextNumber = number;
            }
        }
    }

    Calc.prototype.Calculate = function () {

        switch (this.CurrentAction()) {
            case "add":
                this.Add(_nextNumber);
                break;

            case "subtract":
                this.Subtract(_nextNumber);
                break;

            case Action.None:
                // Do nothing
                break;

            default:
                let msg = "Unexpected action: [" + CurrentAction + "]";
                throw msg;
        }
    }

    Calc.prototype.Add = function (number) {

        _runningTotal += number;
    }

    Calc.prototype.Subtract = function (number) {

        _runningTotal -= number;
    }

    Calc.prototype.Total = function () {

        return _runningTotal;
    }

    Calc.prototype.Clear = function () {

        _runningTotal = 0.0;
        _currentAction = "";
    }

    // Return the instantiated 'class'
    return Calc;

}());

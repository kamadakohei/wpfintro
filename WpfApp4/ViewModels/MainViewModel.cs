using WpfApp4;
using WpfApp4.Models;

namespace WpfApp4.ViewModels
{
    internal class MainViewModel : NotificationObject
    {
        public MainViewModel()
        {
            this._calc = new Calculator();
        }

        private string _lhs = "0.0";

        public string Lhs
        {
            get { return this._lhs; }
            set
            {
                if (SetProperty(ref this._lhs, value))
                {
                    this.DivCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private string _rhs = "0.0";

        public string Rhs
        {
            get { return this._rhs; }
            set
            {
                if (SetProperty(ref this._rhs, value))
                {
                    this.DivCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private string _result;

        public string Result
        {
            get { return this._result; }
            private set { SetProperty(ref this._result, value); }
        }

        private DelegateCommand _divCommand;

        public DelegateCommand DivCommand
        {
            get
            {
                return this._divCommand ?? (this._divCommand = new DelegateCommand(
                _ =>
                {
                    OnDivision();
                },
                _ =>
                {
                    var dummy = 0.0;
                    if (!double.TryParse(this.Lhs, out dummy))
                    {
                        return false;
                    }
                    if(!double.TryParse(this.Rhs, out dummy))
                    {
                        return false;
                    }
                    return true;
                }));
             }
        }

        private Calculator _calc;
        private void OnDivision()
        {
            this._calc.Lhs = double.Parse(this.Lhs);
            this._calc.Rhs = double.Parse(this.Rhs);
            this._calc.ExeuteDiv();
            this.Result = this._calc.Result.ToString();
        }
    }
}

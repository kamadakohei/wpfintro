using Wpf;
using Wpf2.Models;

namespace Wpf2.ViewModels
{
    internal class MainViewModel : NotificationObject
    {
        public MainViewModel()
        {
            this._calc = new Calculator();
        }

        private string _lhs;

        public string Lhs
        {
            get { return this._lhs; }
            set { SetProperty(ref this._lhs, value); }
        }

        private string _rhs;

        public string Rhs
        {
            get { return this._rhs; }
            set { SetProperty(ref this._rhs, value); }
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
                }));
            }
        }

        private Calculator _calc;
        private void OnDivision()
        {
            this._calc.ExeuteDiv();
            this.Result = this._calc.Result.ToString();
        }
    }
}

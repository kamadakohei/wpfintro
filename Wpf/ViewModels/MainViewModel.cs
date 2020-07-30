using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Wpf.ViewModels
{
    internal class MainViewModel : NotificationObject
    {
        private String _upperString;

        /// <summary>
        /// すべての大文字に変換した文字列を取得します。
        /// </summary>
        public string UpperString
        {
            get { return this._upperString; }
            private set
            {
                SetProperty(ref this._upperString, value);}
            }

        private string _inputString;

        public string InputString
        {
            get { return this._inputString; }
            set
            {
                if (SetProperty(ref this._inputString, value))
                {
                    // 入力された文字列を大文字に変換します。
                    this.UpperString = this._inputString.ToUpper();
                    // コマンドの実行可能判別結果に影響を与えているので変更通知をおこないます
                    this.ClearCommand.RaiseCanExecuteChanged();
                    //　出力ウィンドウに結果を表示します。
                    System.Diagnostics.Debug.WriteLine("UpperString=" + this.UpperString);
                }
            }
        }

        private DelegateCommand _clearCommand;


        public DelegateCommand ClearCommand
        {
            get
            {
                if(this._clearCommand == null)
                {
                    this._clearCommand = new DelegateCommand(_ =>
                    {
                        this.InputString = "";
                    },
                    _ => !string.IsNullOrEmpty(this.InputString));
                }
                return this._clearCommand;
            }
        }

    }
}


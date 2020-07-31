using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.ViewModels
{
        internal class MainViewModel : NotificationObject
        {
            private DelegateCommand _openFileCommand;
            /// <summary>
            /// ファイルを開くコマンドを取得します。
            /// </summary>
            public DelegateCommand OpenFileCommand
            {
                get
                {
                    return this._openFileCommand ?? (this._openFileCommand = new DelegateCommand(
                    _ =>
                    {
                        System.Diagnostics.Debug.WriteLine("ファイルを開きます。");
                    }));
                }
            }

            private Action<bool, string> _dialogCallback;

            /// <summary>
            /// ダイアログに対するコールバックを取得します。
            /// </summary>
            public Action<bool, string> DialogCallback
            {
                get { return this._dialogCallback; }
                private set { SetProperty(ref this._dialogCallback, value); }
            }
    }
 }



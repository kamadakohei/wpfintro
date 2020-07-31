using System;
using System.Windows;

namespace WpfApp5.Views.Behaviors
{
    internal class CommonDialogBehavior
    {
        #region Callback 添付プロパティ
        public static readonly DependencyProperty CallBackProperty = DependencyProperty.RegisterAttached("Callback", typeof(Action<bool, string>),
            typeof(CommonDialogBehavior), new PropertyMetadata(null));

        public static Action<bool ,string> GetCallBack(DependencyObject target)
        {
            return (Action<bool, string>)target.GetValue(CallBackProperty);
        }

        public static void SetCallback(DependencyObject target, Action<bool, string> value)
        {
            target.SetValue(CallBackProperty, value);
        }
        #endregion Callback 添付プロパティ
    }
}

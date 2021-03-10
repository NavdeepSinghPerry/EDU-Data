using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LetsMeet
{
   public class PasswordAttachedProperty
    {

        public static bool GetMonitorPasswordChanged(DependencyObject obj)
        {
            return (bool)obj.GetValue(MonitorPasswordChangedProperty);
        }

        public static void SetMonitorPasswordChanged(DependencyObject obj, bool value)
        {
            obj.SetValue(MonitorPasswordChangedProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MonitorPasswordChangedProperty =
            DependencyProperty.RegisterAttached("MonitorPasswordChanged", typeof(bool), typeof(PasswordAttachedProperty), new PropertyMetadata(false,OnPasswordChanged));

        private static void OnPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var password = (d as PasswordBox);
            if (password == null)
                return;

            password.PasswordChanged -= Password_PasswordChanged;
            if ((bool)(e.NewValue))
            {
                SetHasText(password);
                password.PasswordChanged += Password_PasswordChanged;
            }
        }

        private static void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            SetHasText((PasswordBox)sender);
        }

        public static int GetHasText(PasswordBox obj)
        {
            return (int)obj.GetValue(HasTextProperty);
        }

        public static void SetHasText(PasswordBox obj)
        {
            obj.SetValue(HasTextProperty, obj.SecurePassword.Length>0);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HasTextProperty =
            DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(PasswordAttachedProperty), new PropertyMetadata(false));



    }
}

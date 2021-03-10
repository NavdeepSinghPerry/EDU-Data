using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BasicBacgroundWindow
{
   public class PasswordAttachedProperty
    {

        public static bool GetMonitorPassword(DependencyObject obj)
        {
            return (bool)obj.GetValue(MonitorPasswordProperty);
        }

        public static void SetMonitorPassword(DependencyObject obj,bool value)
        {
            obj.SetValue(MonitorPasswordProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MonitorPasswordProperty =
            DependencyProperty.RegisterAttached("MonitorPassword", typeof(bool), typeof(PasswordAttachedProperty), new PropertyMetadata(false,OnPasswordChanged));

        private static void OnPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var password = d as PasswordBox;
            if (d == null)
                return;

            password.PasswordChanged -= Password_PasswordChanged;
            if ((bool)e.NewValue==true)
            {
                password.PasswordChanged += Password_PasswordChanged;
            }

        }

        private static void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            SetHasText((PasswordBox)sender);
            
        }

        public static bool GetHasText(PasswordBox obj)
        {
            return (bool)obj.GetValue(HasTextProperty);
        }

        public static void SetHasText(PasswordBox obj)
        {
            obj.SetValue(HasTextProperty, obj.Password.Length>0);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HasTextProperty =
            DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(PasswordAttachedProperty), new PropertyMetadata(false));


    }
}

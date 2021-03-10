using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LetsApp
{
   public class MonitorPasswordAttachedProperty:BaseAttachedProperty<MonitorPasswordAttachedProperty,bool>
    {
        public override void OnValueUpdated(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

          
            var password = d as PasswordBox;
            if (password == null)
                return;

            password.PasswordChanged -= Password_PasswordChanged;

            if ((bool)e.NewValue)
            {
                HasTextAttachedProperty.SetValue(password,password.Password.Length>0);
                password.PasswordChanged += Password_PasswordChanged;
            }
        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            HasTextAttachedProperty.SetValue((PasswordBox)sender, ((PasswordBox)sender).Password.Length>0);
        }

      
    }



    public class HasTextAttachedProperty : BaseAttachedProperty<HasTextAttachedProperty, bool>
    {

    }



}

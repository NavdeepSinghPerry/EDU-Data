using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LetsApp
{
   public class BaseAttachedProperty<Parent,Property>
        where Parent: BaseAttachedProperty<Parent, Property>, new ()
       {
        public static Parent instance = new Parent();

        public static Property GetValue(DependencyObject obj)
        {            
            return (Property)obj.GetValue(ValueProperty);
        }

        public static void SetValue(DependencyObject obj, Property value)
        {
            obj.SetValue(ValueProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached("Value", typeof(Property), typeof(BaseAttachedProperty<Parent, Property>), new UIPropertyMetadata(default(Property),new PropertyChangedCallback(OnPropertyChanged)));



        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            instance.OnValueUpdated(d, e);
        }

        public virtual void OnValueUpdated(DependencyObject d, DependencyPropertyChangedEventArgs e) { }


    }
}

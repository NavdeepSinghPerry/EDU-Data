using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LetsMeet
{
    /// <summary>
    /// The NoFrameHistory attached property for creating a <see cref="Frame"/> that never shows navigation
    /// and keeps the navigation history empty
    /// </summary>
    public class IsFocusedProperty : BaseAttachedProperty<IsFocusedProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(sender is Control control))
                return;

            control.Loaded += (ss, ee) =>
            {
                control.Focus();
            };
        }

     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LetsMeet
{
    public abstract class AnimateBaseProperty<Parent>: BaseAttachedProperty<Parent, bool>
        where Parent : BaseAttachedProperty<Parent, bool>, new()
    {
        public bool FirstLoad { get; set; } = true;
        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            if (!(sender is FrameworkElement element))
                return;

            //Dont fire if the value is same and is not a first run
            if (sender.GetValue(ValueProperty) == value  && !FirstLoad)
                return;

            //On first load
            if (FirstLoad)
            {
                //Wait for the controls to be loaded because attached properties are loaded before the controls
                RoutedEventHandler onLoaded = null;
                onLoaded = (s, e) =>
                {
                    element.Loaded -= onLoaded;

                    DoAnimation(element, (bool)value);

                    FirstLoad = false;
                };
                element.Loaded += onLoaded;
            }
            else
            {
               DoAnimation(element, (bool)value);
            }

        }

        /// <summary>
        /// The animation method that fires when the value changes
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        protected virtual async void DoAnimation(FrameworkElement element, bool value)
        {
          
        }
    }
    
  public class AnimateSlideForLeft : AnimateBaseProperty<AnimateSlideForLeft>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value)
            {
                await element.SlideAndFadeInFromLeftAsync(FirstLoad ? 0: 0.3f, false);
            }
            else
            {
                await element.SlideAndFadeOutToLeftAsync(FirstLoad ? 0 : 0.3f, false);
            }
        }
    }
}
 
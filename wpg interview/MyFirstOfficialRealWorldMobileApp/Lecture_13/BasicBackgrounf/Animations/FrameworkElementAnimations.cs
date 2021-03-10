using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;


namespace LetsMeet
{
    /// <summary>
    /// Helpers to animate framework elements in specific ways
    /// </summary>
    public static class FrameworkElementAnimations
    {
      
        public static async Task SlideAndFadeInFromRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin=true)
        {
            // Create the storyboard
            var sb = new Storyboard();

            sb.AddSlideFromRight(seconds, element.ActualWidth,keepMargin:keepMargin);
            // Slide in the correct direction
           
            // Add fade in animation
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(element);

            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeInFromLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            // Create the storyboard
            var sb = new Storyboard();

            sb.AddSlideFromLeft(seconds, element.ActualWidth, keepMargin: keepMargin);
            // Slide in the correct direction

            // Add fade in animation
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(element);

            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeOutToLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            // Create the storyboard
            var sb = new Storyboard();

            sb.AddSlideToLeft(seconds, element.ActualWidth, keepMargin: keepMargin);
            // Slide in the correct direction

            // Add fade in animation
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(element);

            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeOutToRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            // Create the storyboard
            var sb = new Storyboard();

            sb.AddSlideToRight(seconds, element.ActualWidth, keepMargin: keepMargin);
            // Slide in the correct direction

            // Add fade in animation
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(element);

            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }



    }
}

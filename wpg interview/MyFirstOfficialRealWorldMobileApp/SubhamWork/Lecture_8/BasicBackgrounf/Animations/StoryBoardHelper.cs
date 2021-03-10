using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace BasicBackgrounf
{
   public static class StoryBoardHelper
    {
        public static void SlideInAndFadeFromRight(this Storyboard storyboard,float seconds, float offset, float deacclerationRatio)
        {
            ThicknessAnimation slideAnimation = new ThicknessAnimation
            {
                From = new Thickness(offset, 0, -offset, 0),
                To = new Thickness(0),
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                DecelerationRatio = deacclerationRatio
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);        
        }

        public static void SlideOutAndFadeToLeft(this Storyboard storyboard, float seconds, float offset, float deacclerationRatio)
        {
            ThicknessAnimation slideAnimation = new ThicknessAnimation
            {
                To = new Thickness(-offset, 0, offset, 0),
                From = new Thickness(0),
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                DecelerationRatio = deacclerationRatio
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }

        public static void FadeIn(this Storyboard storyboard, float seconds, float offset, float deacclerationRatio)
        {
            DoubleAnimation slideAnimation = new DoubleAnimation
            {
                To = 1,
                From =0,
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                DecelerationRatio = deacclerationRatio
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Opacity"));
            storyboard.Children.Add(slideAnimation);
        }
    }
}

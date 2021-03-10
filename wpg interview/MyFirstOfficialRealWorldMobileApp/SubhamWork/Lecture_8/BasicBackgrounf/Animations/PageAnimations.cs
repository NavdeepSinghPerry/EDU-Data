using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace BasicBackgrounf
{
  public static class PageAnimations
    {
        public static void SlideInAndFadeFromRight(this Page page, float seconds, float deacclerationRatio)
        {
            Storyboard sb = new Storyboard();
            sb.SlideInAndFadeFromRight(seconds, (float)Application.Current.MainWindow.Width, deacclerationRatio);
            sb.FadeIn(seconds, (float)Application.Current.MainWindow.Width, deacclerationRatio);
            sb.Begin(page);
            page.Visibility = System.Windows.Visibility.Visible;
        }

        public static void SlideOutAndFadeToLeft(this Page page, float seconds, float deacclerationRatio)
        {
            Storyboard sb = new Storyboard();
            sb.SlideOutAndFadeToLeft(seconds, (float)Application.Current.MainWindow.Width, deacclerationRatio);
            sb.Begin(page);
            page.Visibility = System.Windows.Visibility.Visible;
        }
    }
}

using LetsMeet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace LetsMeet
{
    public class BasePage : Page
    {
        public AnimationType PageLoadAnimation { get; set; } = AnimationType.PageInAndFadeFromRight;

        public AnimationType PageUnloadAnimation { get; set; } = AnimationType.PageOutAndFadeToLeft;


        public float slideTime = 0.8f;

        public bool ShouldAnimateOut { get; set; }
        public BasePage()
        {
            if (PageLoadAnimation != AnimationType.None)
            {
                this.Visibility = System.Windows.Visibility.Collapsed;
            }

            this.Loaded += BasePage_Loaded;

        }

        private async void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (ShouldAnimateOut)
               await AnimateOut();
            else
               await  AnimateIn();
        }

        public async Task AnimateIn()
        {
            if (this.PageLoadAnimation == AnimationType.None)
                return;

            switch (PageLoadAnimation)
            {
                case AnimationType.PageInAndFadeFromRight:
                    var sb = new Storyboard();
                    var slideAnimation = new ThicknessAnimation
                    {
                        From = new System.Windows.Thickness(this.WindowWidth, 0, -this.WindowWidth, 0),
                        To = new System.Windows.Thickness(0),
                        DecelerationRatio = 0.9f,
                        Duration = new System.Windows.Duration(TimeSpan.FromSeconds(this.slideTime))
                    };
                    Storyboard.SetTargetProperty(slideAnimation, new System.Windows.PropertyPath("Margin"));

                    sb.Children.Add(slideAnimation);

                    sb.Begin(this);

                    this.Visibility = System.Windows.Visibility.Visible;
                    break;

            }

        }

        public async Task AnimateOut()
        {
            if (this.PageUnloadAnimation == AnimationType.None)
                return;

            switch (PageUnloadAnimation)
            {
                case AnimationType.PageOutAndFadeToLeft:
                    var sb = new Storyboard();
                    var slideAnimation = new ThicknessAnimation
                    {
                        From = new System.Windows.Thickness(0),
                        To = new System.Windows.Thickness(-this.WindowWidth, 0, this.WindowWidth, 0),
                        DecelerationRatio = 0.9f,
                        Duration = new System.Windows.Duration(TimeSpan.FromSeconds(this.slideTime))
                    };
                    Storyboard.SetTargetProperty(slideAnimation, new System.Windows.PropertyPath("Margin"));

                    sb.Children.Add(slideAnimation);

                    sb.Begin(this);

                    this.Visibility = System.Windows.Visibility.Visible;
                    break;

            }

        }
    }

    public class BasePage<VM> : BasePage
          where VM : BaseViewModel, new()
    {
        private VM mViewModel;


        public VM MViewModel
        {
            get { return mViewModel; }
            set
            {
                if (mViewModel == value)
                    return;

                mViewModel = value;
                this.DataContext = mViewModel;
            }
        }



        public BasePage() : base()
        {

            this.MViewModel = new VM();
        }

    }
}
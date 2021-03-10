using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace BasicBackgrounf
{
  public class BasePage<VM>: Page
        where VM:BaseViewModel, new()
    {
        private VM mViewModel;
        public AnimationType animationType { get; set; } = AnimationType.PageInAndFadeFromRight;

        public float slideTime = 0.8f;

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

       

        public BasePage()
        {
            if(animationType!= AnimationType.None)
            {
                this.Visibility = System.Windows.Visibility.Collapsed;
            }
           
            this.Loaded += BasePage_Loaded;

            this.MViewModel = new VM();
        }

        private void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            AnimateIn();
        }

        public async void AnimateIn()
        {
            if (this.animationType == AnimationType.None) 
                return;

            switch (animationType)
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

        public async void AnimateOut()
        {
            if (this.animationType == AnimationType.None)
                return;

            switch (animationType)
            {
                case AnimationType.PageOutAndFadeToLeft:
                    var sb = new Storyboard();
                    var slideAnimation = new ThicknessAnimation
                    {
                        From = new System.Windows.Thickness(0),
                        To = new System.Windows.Thickness(-this.WindowWidth,0,this.WindowWidth,0 ),
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

        public async Task createStoryBoardForRightIn()
        {
          

        }
    }
}

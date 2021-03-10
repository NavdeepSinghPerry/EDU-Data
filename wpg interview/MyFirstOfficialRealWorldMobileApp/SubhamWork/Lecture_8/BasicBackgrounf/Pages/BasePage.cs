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
    public class BasePage<VM> : Page
          where VM : BaseViewModel, new()
    {
        private VM mViewModel;
        public AnimationType onLoadedAnimation { get; set; } = AnimationType.PageInAndFadeFromRight;
        public AnimationType onUnloadedAnimation { get; set; } = AnimationType.PageOutAndFadeToLeft;

        public float slideTime = 2f;

        public float deaccelaratioRatio = 0.8f;

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
            if (onLoadedAnimation != AnimationType.None)
            {
                this.Visibility = System.Windows.Visibility.Collapsed;
            }

            this.Loaded += BasePage_Loaded;
            this.Unloaded += BasePage_Unloaded;

            this.MViewModel = new VM();
        }

        private void BasePage_Unloaded(object sender, RoutedEventArgs e)
        {
            AnimateOut();
        }

        private void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            AnimateIn();
        }

        public async void AnimateIn()
        {
            if (onLoadedAnimation == AnimationType.None)
                return;

            switch (onLoadedAnimation)
            {
                case AnimationType.PageInAndFadeFromRight:
                    PageAnimations.SlideInAndFadeFromRight(this, slideTime, deaccelaratioRatio);
                    await Task.Delay(500);
                    break;
            }
        }

        public async void AnimateOut()
        {
            if (onUnloadedAnimation == AnimationType.None)
                return;

            switch (onUnloadedAnimation)
            {
                case AnimationType.PageOutAndFadeToLeft:
                    PageAnimations.SlideOutAndFadeToLeft(this, 10f, deaccelaratioRatio);
                    await Task.Delay(5000);
                    break;
            }
        }
    }
}
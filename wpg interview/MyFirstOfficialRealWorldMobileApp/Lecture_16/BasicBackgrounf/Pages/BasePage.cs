using LetsMeet.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace LetsMeet
{

    /// <summary>
    /// Earlier this was inheriting from page
    /// Note: We converted this to inherit from UserControl now and this
    /// will break our sliding in animation of loginPage which is infact
    /// now a usercontrol and the reason is
    /// 1) Page inherits its width from parent control i.e main window
    /// but in usercontrol initially the width is zero becauase it is not
    /// loaded yet so to fix this we have passed window width in SlideAndFadeInFromRightAsync
    /// funtion to fox the animation
    /// </summary>
    public class BasePage : UserControl
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

            if (DesignerProperties.GetIsInDesignMode(this))
                return;

            this.Loaded += BasePage_Loaded;

        }

        private async void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            //don't bother animating in design time 
            //Because if we uncomment this you wont see the page on main window in design time so this is just for user confort while developing an app
          

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
                    await this.SlideAndFadeInFromRightAsync(slideTime,width:(int)Application.Current.MainWindow.Width);
                 
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
                    await this.SlideAndFadeOutToLeftAsync(slideTime);

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LetsApp
{
   public class BasePage<VM>: Page
        where VM: BaseViewModel, new()
    {
        private VM mViewModel;

        public AnimationType onLoadAnimation { get; set; } = AnimationType.PageInAndFadeFromRight;

        public AnimationType onUnloadAnimation { get; set; } = AnimationType.PageOutAndFadeToLeft;

        public VM viewModel
        {
            get { return mViewModel; }
            set
            {
                if (mViewModel == value)
                    return;

                this.DataContext = value;
            }
        }


        public BasePage()
        {

            this.viewModel = new VM();
            this.Loaded += BasePage_Loaded;

        }

        private void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            AnimateIn();
        }

        public async void AnimateIn()
        {
            int y = 0;
        }
    }
}

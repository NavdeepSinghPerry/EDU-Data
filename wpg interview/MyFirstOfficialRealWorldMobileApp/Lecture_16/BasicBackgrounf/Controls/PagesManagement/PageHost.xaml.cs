using LetsMeet.Core;
using LetsMeet.Core.IoC;
using Ninject;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LetsMeet
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {
        /// <summary>
        /// Dependency property is created to change the variable value from XAML otherwise we cannot change or assign values to properties from XAML
        /// For Example in this case we are changing Current Page property from Xamk
        /// </summary>

        public BasePage CurrentPage
        {
            get { return (BasePage)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageProperty =

            DependencyProperty.Register(nameof(CurrentPage), typeof(BasePage), typeof(PageHost), new UIPropertyMetadata(OnCurrentPagePropertyChanged));

      
        private static void OnCurrentPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var newPageFrame = (d as PageHost).NewPage;
            var oldPageFrame = (d as PageHost).OldPage;

            var oldPageContent = newPageFrame.Content;

            newPageFrame.Content = null;

            oldPageFrame.Content = oldPageContent;
            
            if (oldPageContent is BasePage oldPage)
            {
                oldPage.ShouldAnimateOut = true;
            }

            newPageFrame.Content = e.NewValue;
          
        }

        public PageHost()
        {
            InitializeComponent();

            if (DesignerProperties.GetIsInDesignMode(this))
            {
                this.NewPage.Content = (BasePage)new ApplicationLoginPageValueConverter().Convert(IoCContainer.Kernel.Get<ApplicationVM>().CurrentPage);
            }
        }
    }
}

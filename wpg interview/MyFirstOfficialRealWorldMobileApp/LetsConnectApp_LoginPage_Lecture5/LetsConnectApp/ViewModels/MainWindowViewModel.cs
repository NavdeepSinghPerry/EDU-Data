using System.Windows;
using System.Windows.Input;

namespace LetsConnectApp
{
    public class MainWindowViewModel : BaseViewModel
    {

     #region Private properties
        private Window mWindow { get; set; }
      
        private int innerPadding { get; set; } = 10;

        private int resizeBorderThickness { get; set; } = 6;

        private int cornerRadius { get; set; } = 10;
        #endregion

     #region Public properties
        public Thickness InnerPadding { get { return mWindow.WindowState == WindowState.Maximized ? new Thickness(innerPadding) : new Thickness(innerPadding); } }
 
        public Thickness ResizeBorderThickness { get { return new Thickness(resizeBorderThickness + innerPadding); } }

        public CornerRadius CornerRadius { get { return mWindow.WindowState == WindowState.Maximized ? new CornerRadius(0) : new CornerRadius(cornerRadius); } }

        public int CaptionHeight { get; set; } = 20;

        public int TitileHeight { get; set; } = 30;

        public GridLength TitileGridHeight { get { return new GridLength(TitileHeight); } }

        public int DropShadowThickness { get; set; } = 2;

        public ICommand MaximizeCommand { get; set; }
     
        public ICommand MinimizeCommand { get; set; }
      
        public ICommand CloseCommand { get; set; }
       
        public ICommand MenuCommand { get; set; }

        public int minimumScreenWidth { get; set; } = 600;
       
        public int minimumScreenHeight { get; set; } = 600;

        public ApplicationType CurrentPage { get; set; } = ApplicationType.LoginPage;

        #endregion

     /// <summary>
    /// Contructor
    /// </summary>
    /// <param name="window"></param>
     public MainWindowViewModel(Window window)
        {
            mWindow = window;
            mWindow.StateChanged += (sender, e) =>
            {
                this.OnPropertyChanged(nameof(InnerPadding));

                this.OnPropertyChanged(nameof(ResizeBorderThickness));

                this.OnPropertyChanged(nameof(CornerRadius));
            };
            MinimizeCommand = new RelayCommand(() => { mWindow.WindowState = WindowState.Minimized; });
            MaximizeCommand = new RelayCommand(() =>
            {
               
                if (mWindow.WindowState == WindowState.Normal)
                {
                    mWindow.WindowState = WindowState.Maximized;

                }
                else if (mWindow.WindowState == WindowState.Maximized)
                {
                    mWindow.WindowState = WindowState.Normal;

                }
            });
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand= new RelayCommand(() =>SystemCommands.ShowSystemMenu(mWindow,getMousePosition()));
        }

     /// <summary>
    /// Get the currect mouse position
    /// </summary>
    /// <returns></returns>
     private Point getMousePosition()
        {
            var position = Mouse.GetPosition(mWindow);
            return new Point(position.X + mWindow.Left, position.Y + mWindow.Top);
        }

    }
}

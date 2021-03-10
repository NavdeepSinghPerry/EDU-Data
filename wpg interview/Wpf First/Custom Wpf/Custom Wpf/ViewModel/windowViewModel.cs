using System.Windows;
using System.Windows.Input;
using WpfTreeView;

namespace Custom_Wpf.ViewModel
{
  public  class windowViewModel : BaseViewModel
    {
        private Window mWindow;

        public string Test { get; set; } = "Navdeep";

        private int mOuterMarginSize = 10;

        private int mWindowRadius = 10;


        //distance for resize width from edge
        public int ResizeBorder { get; set; } = 6;

        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder+OuterMarginSize); } }


        // for shadow
        public int OuterMarginSize
        {
            get { return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize; }
            set { mOuterMarginSize = value; }
        }
        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

        //for round corners
        public int WindowRadius
        {
            get { return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadius; }
            set { mWindowRadius = value; }
        }

        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        public int TitleHeight { get; set; } = 10;

        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight+ResizeBorder); } }
    
        
        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        private ICommand menuCommand;
        public ICommand MenuCommand { get { return menuCommand; } set { menuCommand = value; } }


        public windowViewModel(Window window)
        {
            mWindow = window;

            //lISTEN for window resizing
            mWindow.StateChanged += (sender, e) =>
            {
                onPropertyChanged(nameof(ResizeBorderThickness));
                onPropertyChanged(nameof(OuterMarginSizeThickness));
                onPropertyChanged(nameof(WindowCornerRadius));
                onPropertyChanged(nameof(WindowRadius));
                onPropertyChanged(nameof(OuterMarginSize));

            };

            //Crete Commands
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(show);
        }

        private void show()
        {
            MessageBox.Show("hwllp");
        }
        private Point getMousePosition( )
        {
            var position = Mouse.GetPosition(mWindow);
            return new Point(position.X + mWindow.Left, position.Y + mWindow.Top);
        }
    }
}








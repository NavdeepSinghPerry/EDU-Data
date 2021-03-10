using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DemoWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1),DispatcherPriority.Normal ,
             delegate
            {
                int newValue = 0;

                if (int.MaxValue == newValue)
                {
                    newValue = 0;
                }
                else
                {
                    newValue = 1 + counter;
                }
                SetValue(counterProperty, newValue);
            }, Dispatcher
            );
            timer.Start();

        }

        public int counter
        {
            get { return (int)GetValue(counterProperty); }
            set { SetValue(counterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for counter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty counterProperty =
            DependencyProperty.Register("counter", typeof(int), typeof(MainWindow), new PropertyMetadata(30));



    }
}

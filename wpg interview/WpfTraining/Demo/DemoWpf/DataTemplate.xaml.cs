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
using System.Windows.Shapes;

namespace DemoWpf
{
    /// <summary>
    /// Interaction logic for DataTemplate.xaml
    /// </summary>
    public partial class DataTemplate : Window
    {
        public customer obj { get; set; }
        public DataTemplate()
        {
            InitializeComponent();
            this.DataContext = this;
            obj = new customer();
        }
    }
    public class customer
    {
        public string Name { get; set; } = "Subham";

        public customer()
        {

        }

    }
}

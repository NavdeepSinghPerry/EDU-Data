using System;
using System.Collections.Generic;
using System.IO;
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

namespace FdPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var drive in Directory.GetLogicalDrives())
            {
                var item = new TreeViewItem();
                item.Header = drive;
                item.Tag = drive;
                item.Items.Add(null);
                item.Expanded += Item_Expanded;
                FolderView.Items.Add(item);
            }
        }

        private void Item_Expanded(object sender, RoutedEventArgs e)
        {
           
            var item = (TreeViewItem)sender;

            if(item.Items.Count!=1 || item.Items[0] != null)
            {
                return;
            }

            item.Items.Clear();

            string path = (string)item.Tag;

            foreach(var contents in Directory.GetDirectories(path))
            {
                TreeViewItem subItem = new TreeViewItem();
                subItem.Header = getName(contents);
                subItem.Tag = contents;
                subItem.Items.Add(null);
                subItem.Expanded += Item_Expanded;
                item.Items.Add(subItem);
            }

            foreach (var contents in Directory.GetFiles(path))
            {
                TreeViewItem subItem = new TreeViewItem();
                subItem.Header = getName(contents);
                subItem.Tag = contents;
                subItem.Expanded += Item_Expanded;
                item.Items.Add(subItem);
            }


        }
        public static string getName(string fullPath)
        {
            return fullPath.Split('\\').Last();
        }
        
    }
}

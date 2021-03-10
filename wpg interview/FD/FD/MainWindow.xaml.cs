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

namespace FD
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
         foreach(var directoryItem in Directory.GetLogicalDrives())
            {
                var item = new TreeViewItem();
                item.Header = directoryItem;
                item.Tag = directoryItem;
                item.Expanded += Item_Expanded;
                //add a default item
                item.Items.Add(null);


                FolderView.Items.Add(item);

            }

        }

        private void Item_Expanded(object sender, RoutedEventArgs e)
        {
            
            var treeViewItem = (TreeViewItem)sender;
            if(treeViewItem.Items.Count!=1 || treeViewItem.Items[0] != null)
            {
                return;
            }
            treeViewItem.Items.Clear();
            var fullPath =(string)treeViewItem.Tag;

            // Updating Directories
            foreach (var item in Directory.GetDirectories(fullPath))
            {
                var subItem = new TreeViewItem();
                subItem.Header = getFolderName(item);
                subItem.Tag = item;
                subItem.Expanded += Item_Expanded;
                subItem.Items.Add(null);
                treeViewItem.Items.Add(subItem);

            }

            // Updating Files
            foreach (var item in Directory.GetFiles(fullPath))
            {
                var subItem = new TreeViewItem();
                subItem.Header = getFolderName(item);
                subItem.Tag = item;
                treeViewItem.Items.Add(subItem);

            }


        }

        public static string getFolderName(string path)
        {

            string name =path.Split('\\').Last();

            return name;
        }


    }
}

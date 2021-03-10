using LetsMeet.Core.IoC;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LetsMeet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IoCContainer.Setup();

            //Show the main Window

            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }
    }
}

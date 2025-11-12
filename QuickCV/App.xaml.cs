using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using QuickCV.ViewModel;

namespace QuickCV
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void OnStartup(object sender, StartupEventArgs e)
        {
            _navigator = new Navigator();
            _mainWindowViewModel = new MainWindowViewModel(_navigator);

            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = _mainWindowViewModel;
            mainWindow.Show();
            

        }
        
        private Navigator _navigator;
        private MainWindowViewModel _mainWindowViewModel;
    }
}

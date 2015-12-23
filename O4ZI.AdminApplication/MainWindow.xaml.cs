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

namespace O4ZI.AdminApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Intro.Navigate(new Intro());
        }

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_OnManageUsers(object sender, RoutedEventArgs routedEventArgs)
        {
            Intro.Navigate(new ManageUsers());
        }

        private void MenuItem_OnManageApplication(object sender, RoutedEventArgs routedEventArgs)
        {
            Intro.Navigate(new ManageApplication());
        }


    }
}

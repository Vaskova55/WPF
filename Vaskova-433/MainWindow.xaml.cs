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
using Vaskova_433.Classes;
using Vaskova_433.Pages;

namespace Vaskova_433
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
            FrNav.Navigate(new HomePage());
        }

        private void Bt_Home_Click(object sender, RoutedEventArgs e)
        {
            FrNav.Navigate(new HomePage());
        }

        private void Bt_Users_Click(object sender, RoutedEventArgs e)
        {
            FrNav.Navigate(new UsersPage());
        }

        private void Bt_UserList_Click(object sender, RoutedEventArgs e)
        {
            FrNav.Navigate(new ListPage());
        }
    }
}

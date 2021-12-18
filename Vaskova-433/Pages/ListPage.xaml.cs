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
using Vaskova_433.Classes.Entityes;

namespace Vaskova_433.Pages
{
    /// <summary>
    /// Interaction logic for ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        public ListPage()
        {
            InitializeComponent();
            LV_Users.ItemsSource = EfModel.init().Users.ToList();
        }

        private void bt_Pass(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            UsersClass user = (UsersClass)button.DataContext;
            MessageBox.Show(user.password);
        }
    }
}

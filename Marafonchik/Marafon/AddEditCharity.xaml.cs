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

namespace Marafon
{
    /// <summary>
    /// Логика взаимодействия для AddEditCharity.xaml
    /// </summary>
    public partial class AddEditCharity : Window
    {
        public AddEditCharity()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manage_charities manage_Charities = new Manage_charities();
            manage_Charities.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manage_charities manage_Charities = new Manage_charities();
            manage_Charities.Show();
            Close();
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            Manage_charities manage_Charities = new Manage_charities();
            manage_Charities.Show();
            Close();
        }
    }
}

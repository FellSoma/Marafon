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
    /// Логика взаимодействия для Manage_charities.xaml
    /// </summary>
    public partial class Manage_charities : Window
    {
        public Manage_charities()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            AdministratorMenu administratorMenu = new AdministratorMenu();
            administratorMenu.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEditCharity addEditCharity = new AddEditCharity();
            addEditCharity.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddEditCharity addEditCharity = new AddEditCharity();
            addEditCharity.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddEditCharity addEditCharity = new AddEditCharity();
            addEditCharity.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddEditCharity addEditCharity = new AddEditCharity();
            addEditCharity.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AddEditCharity addEditCharity = new AddEditCharity();
            addEditCharity.Show();
            Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AddEditCharity addEditCharity = new AddEditCharity();
            addEditCharity.Show();
            Close();
        }
    }
}

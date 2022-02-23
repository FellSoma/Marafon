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
    /// Логика взаимодействия для AdministratorMenu.xaml
    /// </summary>
    public partial class AdministratorMenu : Window
    {
        public AdministratorMenu()
        {
            InitializeComponent();
        }

        private void userManagment(object sender, RoutedEventArgs e)
        {
            UserManagement w = new UserManagement();
            w.Show();
        }

        private void ValantersManagment(object sender, RoutedEventArgs e)
        {
            VolunteerManagement w = new VolunteerManagement();
            w.Show();
        }

        private void manageCertil(object sender, RoutedEventArgs e)
        {
            Manage_charities w = new Manage_charities();
            w.Show();
        }

        private void inVernory(object sender, RoutedEventArgs e)
        {
            inventar w = new inventar();
            w.Show();
        }
    }
}

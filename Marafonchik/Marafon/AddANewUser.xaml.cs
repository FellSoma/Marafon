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
    /// Логика взаимодействия для AddANewUser.xaml
    /// </summary>
    public partial class AddANewUser : Window
    {
        public AddANewUser()
        {
            InitializeComponent();
        }

        private void ILogin(object sender, RoutedEventArgs e)
        {
            UserManagement w = new UserManagement();
            w.Show();
            this.Close();
        }

        private void Registry(object sender, RoutedEventArgs e)
        {
            UserManagement w = new UserManagement();
            w.Show();
            Close();
        }
    }
}

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
    /// Логика взаимодействия для iLogin.xaml
    /// </summary>
    public partial class iLogin : Window
    {
        public iLogin()
        {
            InitializeComponent();
        }

        private void Runner(object sender, RoutedEventArgs e)
        {
            Window g = new Regystry();
            g.Show();
        }

        private void cordinator(object sender, RoutedEventArgs e)
        {
            Window g = new CordinatorMenu();
            g.Show();
        }

        private void admin(object sender, RoutedEventArgs e)
        {
            Window g = new AdministratorMenu();
            g.Show();
        }
    }
}

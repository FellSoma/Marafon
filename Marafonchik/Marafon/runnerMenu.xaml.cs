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
    /// Логика взаимодействия для runnerMenu.xaml
    /// </summary>
    public partial class runnerMenu : Window
    {
        public runnerMenu()
        {
            InitializeComponent();
        }

        private void contacts(object sender, RoutedEventArgs e)
        {
            Window g = new Contacts();
            g.Show();
        }

        private void editRunner(object sender, RoutedEventArgs e)
        {
            Window g = new EditRunner();
            g.Show();
        }

        private void regMarafoon(object sender, RoutedEventArgs e)
        {
            Window g = new RegMarafon();
            g.Show();
        }

        private void myResult(object sender, RoutedEventArgs e)
        {
            Window g = new MyResault();
            g.Show();
        }

        private void mySponsor(object sender, RoutedEventArgs e)
        {
            Window g = new MySponsor();
            g.Show();

        }

        private void close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

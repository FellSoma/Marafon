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
    /// Логика взаимодействия для ImportVolunteers.xaml
    /// </summary>
    public partial class ImportVolunteers : Window
    {
        public ImportVolunteers()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            AdministratorMenu am = new AdministratorMenu();
            am.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VolunteerManagement vm = new VolunteerManagement();
            vm.Show();
            Close();
        }
    }
}

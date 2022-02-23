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
    /// Логика взаимодействия для RunnerManagement.xaml
    /// </summary>
    public partial class RunnerManagement : Window
    {
        public RunnerManagement()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            Window w = new CordinatorMenu();
            w.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             Window w = new MainWindow();
            w.Show();
            Close();
        }
    }
}

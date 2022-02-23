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
    /// Логика взаимодействия для Certificate_preview.xaml
    /// </summary>
    public partial class Certificate_preview : Window
    {
        public Certificate_preview()
        {
            InitializeComponent();
        }

        private void btBack_Copy_Click(object sender, RoutedEventArgs e)
        {
            EditRunner editRunner = new EditRunner();
            editRunner.Show();
            Close();
        }

        private void btLogout_Copy_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}

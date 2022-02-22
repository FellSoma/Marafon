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
    /// Логика взаимодействия для EditRunner.xaml
    /// </summary>
    public partial class EditRunner : Window
    {
        public EditRunner()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Window w = new runnerMenu();
            w.Show();
            Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {     
            Close();
        }
    }
}

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
    /// Логика взаимодействия для inventar.xaml
    /// </summary>
    public partial class inventar : Window
    {
        public inventar()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Otchet otchet = new Otchet();
            otchet.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            postinvent postinvent = new postinvent();
            postinvent.Show();
        }
    }
}

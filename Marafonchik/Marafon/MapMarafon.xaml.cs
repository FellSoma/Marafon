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
    /// Логика взаимодействия для MapMarafon.xaml
    /// </summary>
    public partial class MapMarafon : Window
    {
        public MapMarafon()
        {
            InitializeComponent();
        }

        private void checkPoint(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
        }

        private void checkPointMenu(object sender, RoutedEventArgs e)
        {
            menu.Visibility =  Visibility.Collapsed;
        }

        private void close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

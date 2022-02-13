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
    /// Логика взаимодействия для MarafonInfoxaml.xaml
    /// </summary>
    public partial class MarafonInfoxaml : Window
    {
        public MarafonInfoxaml()
        {
            InitializeComponent();
        }

        private void mapMarafon(object sender, RoutedEventArgs e)
        {
            Window g = new MapMarafon();
            g.Show();
        }

        private void close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

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
    /// Логика взаимодействия для RegMarafon.xaml
    /// </summary>
    public partial class RegMarafon : Window
    {
        public RegMarafon()
        {
            InitializeComponent();
        }

        private void Sponsor(object sender, RoutedEventArgs e)
        {
            Window g = new Sponsor();
            g.Show();
        }

        private void thxRunner(object sender, RoutedEventArgs e)
        {
            Window g = new ThxRunner();
            g.Show();
        }
    }
}

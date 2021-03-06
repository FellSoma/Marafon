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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Marafon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void IfuRunner(object sender, RoutedEventArgs e)
        {
            Window g = new IfuRunner();
            g.Show();
        }

        private void sponsorRunner(object sender, RoutedEventArgs e)
        {
            Window g = new SponsorRunner();
            g.Show();
        }

        private void info(object sender, RoutedEventArgs e)
        {
            Window g = new Info();
            g.Show();
        }
    }
}

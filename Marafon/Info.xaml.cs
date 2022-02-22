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
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class Info : Window
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void marofonInfo(object sender, RoutedEventArgs e)
        {
            Window g = new MarafonInfoxaml();
            g.Show();
        }

        private void sponsorStack(object sender, RoutedEventArgs e)
        {
            Window w = new SponsorStack();
            w.Show();
        }

        private void earlyRase(object sender, RoutedEventArgs e)
        {
            Window w = new EarlyRace();
            w.Show();
        }

        private void howMuchMarafon(object sender, RoutedEventArgs e)
        {
            Window w = new HowMuchMarafon();
            w.Show(); 
        }

        private void BMR(object sender, RoutedEventArgs e)
        {
            BMRcalculator bMRcalculator = new BMRcalculator();
            bMRcalculator.Show();
        }
    }
}

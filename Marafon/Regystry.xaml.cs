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
    /// Логика взаимодействия для Regystry.xaml
    /// </summary>
    public partial class Regystry : Window
    {
        public Regystry()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            
        //    Email.Text = "help message";//подсказка
          //  Email.Foreground = Color.Multiply(, 0,1);
        }

        private void Enter(object sender, ContextMenuEventArgs e)
        {
       //     Email.Text = null;
          //  Email.Foreground();
        }

        private void Ilogin(object sender, RoutedEventArgs e)
        {

        }

        private void regMarafon(object sender, RoutedEventArgs e)
        {
            Window g = new RegMarafon();
            g.Show();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

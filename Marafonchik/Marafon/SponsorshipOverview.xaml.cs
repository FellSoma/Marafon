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
    /// Логика взаимодействия для SponsorshipOverview.xaml
    /// </summary>
    public partial class SponsorshipOverview : Window
    {
        public SponsorshipOverview()
        {
            InitializeComponent();
        }

        public class T
        {
            public T(string Наименование, string Сумма)
            {
                this.Наименование = Наименование;
                this.Сумма = Сумма;
            }

            public string Наименование { get; set; }
            public string Сумма { get; set; }
        }
        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            Image finalImage = new Image();
            //finalImage.Width = 80;
            //BitmapImage logo = new BitmapImage();
            //logo.BeginInit();
            //logo.UriSource = new Uri("pack://application:,,,/AssemblyName;component/Resources/foto/logo.png");
            //logo.EndInit();
            //finalImage.Source = logo;
            List<T> result = new List<T>(6)
            {
                new T( "2h 26m 27s", "First Runner"),
                new T( "2h 26m 28s", "Second Runner"),
                new T( "2h 26m 29s", "Third Runner"),
                new T("2h 26m 30s", "Fourth Runner"),
                new T("2h 26m 31s", "Fifth Runne"),
                new T( "2h 27m 20s", "Sixth Runner")
            };
            phonesGrid.ItemsSource = result;
        }

        private void closeClick(object sender, RoutedEventArgs e)
        {
            Window g = new MainWindow();
            g.Show();
            Close();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            Window g = new CordinatorMenu();
            g.Show();
            Close();
        }
    }
}

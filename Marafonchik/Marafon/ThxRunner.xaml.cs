﻿using System;
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
    /// Логика взаимодействия для ThxRunner.xaml
    /// </summary>
    public partial class ThxRunner : Window
    {
        public ThxRunner()
        {
            InitializeComponent();
        }

        private void runnerMenu(object sender, ContextMenuEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window w = new runnerMenu();
            w.Show();
            Close();
        }

        private void close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

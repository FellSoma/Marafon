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
    /// Логика взаимодействия для EditRunnerProfile.xaml
    /// </summary>
    public partial class EditRunnerProfile : Window
    {
        public EditRunnerProfile()
        {
            InitializeComponent();
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

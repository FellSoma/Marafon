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
    /// Логика взаимодействия для SponsorStack.xaml
    /// </summary>
    public partial class SponsorStack : Window
    {
        public SponsorStack()
        {
            InitializeComponent();
        }

        private void close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
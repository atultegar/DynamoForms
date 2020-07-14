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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DynamoForms
{
    /// <summary>
    /// Interaction logic for MultiSelect.xaml
    /// </summary>
    public partial class MultiSelect : Window
    {
        public MultiSelect()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}

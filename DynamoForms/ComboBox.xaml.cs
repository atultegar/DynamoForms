﻿using Autodesk.DesignScript.Runtime;
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

namespace DynamoForms
{
    /// <summary>
    /// Interaction logic for ComboBox.xaml
    /// </summary>
    [IsVisibleInDynamoLibrary(false)]
    public partial class ComboBox : Window
    {
        /// <summary>
        /// WPF Form with combobox and Ok, Cancel buttons
        /// </summary>
        [IsVisibleInDynamoLibrary(false)]
        public ComboBox()
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

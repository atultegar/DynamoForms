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
    /// Interaction logic for SelectionList.xaml
    /// </summary>
    public partial class SelectionList : Window
    {
        /// <summary>
        /// 
        /// </summary>
        public SelectionList()
        {
            InitializeComponent();
        }

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            MoveAllItems(lstUnselected, lstSelected);
        }

        private void btn_Ok_Click (object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            MoveSelectedItems(lstUnselected, lstSelected);
        }

        private void btnDeselect_Click(object sender, RoutedEventArgs e)
        {
            MoveSelectedItems(lstSelected, lstUnselected);
        }

        private void btnDeselectAll_Click(object sender, RoutedEventArgs e)
        {
            MoveAllItems(lstSelected, lstUnselected);
        }

        // Move selected items from one ListBox to another
        private void MoveSelectedItems(ListBox lstFrom, ListBox lstTo)
        {
            while (lstFrom.SelectedItems.Count > 0)
            {
                var item = lstFrom.SelectedItems[0];
                lstTo.Items.Add(item);
                lstFrom.Items.Remove(item);
            }
            SetButtonsEditable();
        }

        private void MoveAllItems(ListBox lstFrom, ListBox lstTo)
        {
            for (int i = 0; i < lstFrom.Items.Count; i++)
            {
                lstTo.Items.Add(lstFrom.Items[i]);
            }

            lstFrom.Items.Clear();
            SetButtonsEditable();
        }

        // Enable and disable buttons.
        private void SetButtonsEditable()
        {
            btnSelect.IsEnabled = (lstUnselected.Items.Count > 0);
            btnSelectAll.IsEnabled = (lstUnselected.Items.Count > 0);
            btnDeselect.IsEnabled = (lstSelected.Items.Count > 0);
            btnDeselectAll.IsEnabled = (lstSelected.Items.Count > 0);
        }
    }
}

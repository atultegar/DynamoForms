using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Autodesk.DesignScript.Geometry;

namespace DynamoForms
{
    /// <summary>
    /// Forms for input
    /// </summary>
    public class Forms
    {
        /// <summary>
        /// Form with combobox for input
        /// </summary>
        /// <param name="title"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        [STAThread]
        public static object FormComboBox(String title, List<object> list)
        {
            
            ComboBox window = new ComboBox();

            window.lbl_1.Content = string.Format("Select {0} from list", title);
            window.cmbBox.ItemsSource = list;

            var res = window.ShowDialog();
            if (!res.HasValue && res.Value)
                window.Close();
            var idx = window.cmbBox.SelectedIndex;
            return list[idx];
        }

        /// <summary>
        /// Form with List Box for inputs
        /// </summary>
        /// <param name="title"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        [STAThread]
        public static IList<object> FormMultiSelect(String title, List<object> list)
        {
            //IList<object> output = new List<object>();
            MultiSelect window = new MultiSelect();

            window.tb_1.Text = string.Format("Select {0} from list box", title);
            window.lstBox.ItemsSource = list;

            var res = window.ShowDialog();
            if (!res.HasValue && res.Value)
                window.Close();
            IList<object> data = (IList<object>)window.lstBox.SelectedItems;
            
            return data;
        }
    }
}

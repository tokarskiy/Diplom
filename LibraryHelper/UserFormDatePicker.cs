using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryHelper
{
    public partial class UserFormDatePicker : Form
    {
        private DateTime? chosenDate;
        public UserFormDatePicker(DateTime? DefaultValue = null)
        {
            InitializeComponent();
            dateTimePicker.Value = DefaultValue != null ? DefaultValue.Value : DateTime.Today;
            chosenDate = DefaultValue;
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            chosenDate = dateTimePicker.Value;
            Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            chosenDate = null;
            Close();
        }

        public DateTime? ShowAndChooseDate()
        {
            ShowDialog();
            return chosenDate;
        }
    }
}

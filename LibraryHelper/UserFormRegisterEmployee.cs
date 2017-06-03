using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelocityDb.Session;

namespace LibraryHelper
{
    public partial class UserFormRegisterEmployee : Form
    {
        private DateTime? birthDate;
        public UserFormRegisterEmployee()
        {
            InitializeComponent();
            birthDateBox.Text = "---Empty---";
            birthDate = null;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                MessageBox.Show("Error * ",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!PasswordMatch())
            {
                MessageBox.Show("Passwords must match. ",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (CheckDuplicateLogin())
            {
                MessageBox.Show("This login already exists. ", 
                                "Error", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                return;
            }

            
            StoreEmployeeObject();

            
            Close();
        }

        private Employee MakeEmployeeObject()
        {
            var employee = new Employee
            {
                FirstName = firstNameBox.Text,
                LastName = lastNameBox.Text,
                MiddleName = middleNameBox.Text != String.Empty ? middleNameBox.Text : null,
                BirthDate = birthDate,
                Login = loginBox.Text,
                Password = passwordBox.Text
            };

            if (emailBox.Text != String.Empty)
            {
                employee.AddEmail(emailBox.Text);
            }

            if (phoneBox.Text != String.Empty)
            {
                employee.AddPhone(phoneBox.Text);
            }

            return employee;
        }

        private void StoreEmployeeObject()
        {
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginUpdate();
                var employee = MakeEmployeeObject();
                conn.Persist(employee);
                ThisApplication.Instance.CurrentEmployee = employee;
                conn.Commit();
            } 
        }

        private bool CheckDuplicateLogin()
        {
            bool result;
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginRead();
                result = conn.AllObjects<Employee>().Any(x => x.Login == loginBox.Text);
                conn.Commit();
            }
            return result;
        }

        private bool CheckEmpty()
        {
            return firstNameBox.Text == String.Empty ||
                   lastNameBox.Text == String.Empty ||
                   loginBox.Text == String.Empty ||
                   passwordBox.Text == String.Empty;
        }

        private bool PasswordMatch()
        {
            return passwordBox.Text == password1Box.Text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeBirthDateButton_Click(object sender, EventArgs e)
        {
            var window = new UserFormDatePicker();
            birthDate = window.ShowAndChooseDate();

            birthDateBox.Text = birthDate.HasValue ?
                birthDate.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) :
                "---Empty---";
        }
    }
}

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

namespace LibraryHelper
{
    public partial class UserFormAddClient : Form
    {
        private DateTime? birthDate;
        private Client currentClient;

        public UserFormAddClient()
        {
            InitializeComponent();
            birthDateBox.Text = "---Empty---";
            birthDate = null;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                MessageBox.Show("The fields marked by * sign are nessessary to be filled. ",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (SameCodeExists())
            {
                MessageBox.Show("The client with this code already exists. ",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            StoreEmployeeObject();
            Close();
        }

        private Client MakeClientObject()
        {
            var client = new Client
            {
                Code = codeBox.Text,
                FirstName = firstNameBox.Text,
                LastName = lastNameBox.Text,
                MiddleName = middleNameBox.Text != String.Empty ? middleNameBox.Text : null,
                BirthDate = birthDate
            };

            if (emailBox.Text != String.Empty)
            {
                client.AddEmail(emailBox.Text);
            }

            if (phoneBox.Text != String.Empty)
            {
                client.AddPhone(phoneBox.Text);
            }

            currentClient = client;
            return client;
        }

        private void StoreEmployeeObject()
        {
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginUpdate();
                var client = MakeClientObject();
                conn.Persist(client);
                conn.Commit();
            }
        }

        private bool CheckEmpty()
        {
            return firstNameBox.Text == String.Empty ||
                   lastNameBox.Text == String.Empty ||
                   codeBox.Text == String.Empty;
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

        public Client ShowAndAddClient()
        {
            ShowDialog();
            return currentClient;
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            currentClient = null;
            Close();
        }

        private bool SameCodeExists()
        {
            bool result;
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginRead();
                result = conn.AllObjects<Client>().Any(x => x.Code == codeBox.Text);
                conn.Commit();
            }
            return result;
        }

        private void ChangeBirthDateButton_Click_1(object sender, EventArgs e)
        {
            var window = new UserFormDatePicker(birthDate);
            birthDate = window.ShowAndChooseDate();
            birthDateBox.Text = birthDate.HasValue ?
                birthDate.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) :
                "---Empty---";
        }
    }
}

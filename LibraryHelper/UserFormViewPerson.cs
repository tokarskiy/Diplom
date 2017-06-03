using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Globalization;

namespace LibraryHelper
{
    public partial class UserFormViewPerson : Form
    {
        private Person currentPerson;
        private DateTime? birthDate;
        public UserFormViewPerson(Person person)
        {
            currentPerson = person;
            InitializeComponent();
            InitializeUserFormData();
            Text = person.ToString(); //Change the caption of the window

            UpdateEmailButton.Enabled = false;
            RemoveEmailButton.Enabled = false;
            UpdatePhoneButton.Enabled = false;
            RemovePhoneButton.Enabled = false;
        }

        private void InitializeUserFormData()
        {
            firstNameBox.Text = currentPerson.FirstName;
            lastNameBox.Text = currentPerson.LastName;
            middleNameBox.Text = currentPerson.MiddleName ?? String.Empty;
            birthDate = currentPerson.BirthDate;
            birthDateBox.Text = birthDate.HasValue ?
                birthDate.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) :
                "---Empty---";

            foreach (var email in currentPerson.Emails)
            {
                emailsBox.Items.Add(email);
            }

            foreach (var phone in currentPerson.Phones)
            {
                phonesBox.Items.Add(phone);
            }
        }

        private bool CheckEmpty()
        {
            return firstNameBox.Text == String.Empty ||
                   lastNameBox.Text == String.Empty;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                MessageBox.Show("First name and last name must be filled. ",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            using (var session = ThisApplication.Instance.Session)
            {
                session.BeginUpdate();

                currentPerson = session
                    .AllObjects<Person>()
                    .FirstOrDefault(x => x.Id == currentPerson.Id);

                currentPerson.FirstName = firstNameBox.Text;
                currentPerson.LastName = lastNameBox.Text;
                currentPerson.MiddleName = middleNameBox.Text != String.Empty ? middleNameBox.Text : null;
                currentPerson.BirthDate = birthDate;

                currentPerson.ClearPhones();
                foreach (string phone in phonesBox.Items)
                {
                    currentPerson.AddPhone(phone);
                }

                currentPerson.ClearEmails();
                foreach (string email in emailsBox.Items)
                {
                    currentPerson.AddEmail(email);
                }

                currentPerson.Update();
                session.Commit();
            }
            Close();
        }

        private void AddEmailButton_Click(object sender, EventArgs e)
        {
            var email = Interaction.InputBox("Enter an email");
            if (email == String.Empty)
            {
                return;
            }

            emailsBox.Items.Add(email);
        }

        private void UpdateEmailButton_Click(object sender, EventArgs e)
        {
            int index = emailsBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            var email = Interaction.InputBox(
                Prompt: "Enter an email", 
                DefaultResponse: (string)emailsBox.Items[index]);

            emailsBox.Items[index] = email;
        }

        private void RemoveEmailButton_Click(object sender, EventArgs e)
        {
            int index = emailsBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            emailsBox.Items.RemoveAt(index);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeBirthDateButton_Click(object sender, EventArgs e)
        {
            var window = new UserFormDatePicker(currentPerson.BirthDate);
            birthDate = window.ShowAndChooseDate();
            birthDateBox.Text = birthDate.HasValue ? 
                birthDate.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) : 
                "---Empty---";
        }

        private void AddPhoneButton_Click(object sender, EventArgs e)
        {
            var phone = Interaction.InputBox("Enter a phone");
            if (phone == String.Empty)
            {
                return;
            }

            phonesBox.Items.Add(phone);
        }

        private void UpdatePhoneButton_Click(object sender, EventArgs e)
        {
            int index = phonesBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            var phone = Interaction.InputBox(
                Prompt: "Enter a phone ",
                DefaultResponse: (string)phonesBox.Items[index]);

            phonesBox.Items[index] = phone;
        }

        private void RemovePhoneButton_Click(object sender, EventArgs e)
        {
            int index = phonesBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            phonesBox.Items.RemoveAt(index);
        }

        private void emailsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEmailButton.Enabled = emailsBox.SelectedIndex >= 0;
            RemoveEmailButton.Enabled = emailsBox.SelectedIndex >= 0;
        }

        private void phonesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePhoneButton.Enabled = phonesBox.SelectedIndex >= 0;
            RemovePhoneButton.Enabled = phonesBox.SelectedIndex >= 0;
        }
    }
}

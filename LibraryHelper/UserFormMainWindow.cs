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
    public partial class UserFormMainWindow : Form
    {
        public UserFormMainWindow()
        {
            InitializeComponent();
            var window = new UserFormBirthdayReminder();
            window.ShowIfBirthdaysExists();
            databaseNameBox.Text = ThisApplication.Instance.DatabaseName;
            userNameBox.Text = ThisApplication.Instance.CurrentEmployee.ToString();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            var window = new UserFormViewPersonsList(UserFormViewPersonsList.ViewMode.Employees);
            window.ShowDialog();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            var window = new UserFormViewBooksList();
            window.ShowDialog();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            var window = new UserFormAddBook();
            var book = window.ShowAndReturnBook();
            if (book == null)
            {
                return;
            }

            var window2 = new UserFormViewBook(book);
            window2.ShowDialog();
        }

        private void DeptorsButton_Click(object sender, EventArgs e)
        {
            var window = new UserFormViewDebtors();
            window.ShowDialog();
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            var window = new UserFormViewPersonsList(UserFormViewPersonsList.ViewMode.Clients);
            window.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            ThisApplication.Instance.CurrentEmployee = null;
            Close();
        }

        private void BirthdaysButton_Click(object sender, EventArgs e)
        {
            var window = new UserFormBirthdayReminder();
            window.ShowIfBirthdaysExists(true);
        }
    }
}

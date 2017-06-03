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
    public partial class UserFormLogin : Form
    {
        private Employee logined;

        public UserFormLogin()
        {
            InitializeComponent();
               
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginRead();
                logined = conn.AllObjects<Employee>().FirstOrDefault(x =>
                {
                    return x.Login == loginBox.Text && x.Password == passwordBox.Text;
                });
                conn.Commit();
            }

            if (logined == null)
            {
                MessageBox.Show("Access denied. ",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            Close();
        }

        public Employee ShowAndLogin()
        {
            ShowDialog();
            var screenSize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point
            {
                X = screenSize.Width / 2 - Width / 2,
                Y = screenSize.Height / 2 - Height / 2
            };

            return logined;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            logined = ThisApplication.Instance.CurrentEmployee;
            Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            var window = new UserFormRegisterEmployee();
            window.ShowDialog();

            if (ThisApplication.Instance.CurrentEmployee == null)
            {
                Show();
                return;
            }

            logined = ThisApplication.Instance.CurrentEmployee;
            Close();
        }
    }
}

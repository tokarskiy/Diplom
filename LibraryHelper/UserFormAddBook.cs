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
    public partial class UserFormAddBook : Form
    {
        private Book currentBook;
        public UserFormAddBook()
        {
            InitializeComponent();
            ageLimitBox.Maximum = DateTime.Today.Year;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginUpdate();
                currentBook = new Book
                {
                    Code = codeBox.Text,
                    Name = nameBox.Text,
                    Author = authorBox.Text,
                    AgeLimit = (int)ageLimitBox.Value,
                    ReleaseYear = (int)yearBox.Value
                };
                conn.Persist(currentBook);
                conn.Commit();
            }
            Close();
        }

        public Book ShowAndReturnBook()
        {
            ShowDialog();
            return currentBook;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            currentBook = null;
            Close();
        }
    }
}

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
    public partial class UserFormViewBooksList : Form
    {
        private List<Book> books;
        public UserFormViewBooksList()
        {
            InitializeComponent();

            ReinitializeBookList();
        }

        private void ReinitializeBookList()
        {
            booksBox.Items.Clear();
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginRead();
                books = conn.AllObjects<Book>().ToList();
                conn.Commit();
            }

            foreach (var book in books)
            {
                booksBox.Items.Add(new ListViewItem(new string[]
                {
                    book.Code,
                    book.Name,
                    book.Author,
                    book.IsAvailable ? "Yes" : "No"
                }));
            }
        }

        private void booksBox_DoubleClick(object sender, EventArgs e)
        {
            int index = booksBox.SelectedIndices[0];
            if (index < 0)
            {
                return;
            }
            var window = new UserFormViewBook(books[index]);
            window.ShowDialog();
            ReinitializeBookList();
        }
    }
}

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
    public partial class UserFormViewBook : Form
    {
        private Book currentBook;
        private List<Book.OwnerInfo> ownersInfo;

        public UserFormViewBook(Book book)
        {
            InitializeComponent();
            
            currentBook = book;
            ownersInfo = book.Owners.ToList();
            Reinitialize();

            ReturnedButton.Enabled = !book.IsAvailable;
            NewOwnerButton.Enabled = book.IsAvailable;
        }
        
        private void Reinitialize()
        {
            var book = currentBook;

            nameBox.Text = book.Name;
            codeBox.Text = book.Code;
            codeBox.Enabled = false;
            authorBox.Text = book.Author;

            yearBox.Value = book.ReleaseYear;
            ageLimitBox.Update();
            ageLimitBox.Value = book.AgeLimit;

            ownersBox.Items.Clear();
            foreach (var ownerInfo in ownersInfo)
            {
                ownersBox.Items.Add(new ListViewItem(new string[]
                {
                    ownerInfo.StartDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ownerInfo.EndDate.HasValue ?
                        ownerInfo.EndDate.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) :
                        "Not returned",
                    ownerInfo.Client.ToString()
                }));
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginUpdate();

                currentBook = conn
                    .AllObjects<Book>()
                    .FirstOrDefault(x => x.Id == currentBook.Id);

                currentBook.Name = nameBox.Text;
                currentBook.Code = codeBox.Text;
                currentBook.Author = authorBox.Text;
                currentBook.AgeLimit = (int)ageLimitBox.Value;
                currentBook.ReleaseYear = (int)yearBox.Value;

                currentBook.Update();

                currentBook.AddOwnerInfoList(conn, ownersInfo);

                conn.Commit();
            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewOwnerButton_Click(object sender, EventArgs e)
        {
            var person = 
                new UserFormChoosePerson(UserFormChoosePerson.PersonViewType.ClientsOnly)
                .ShowAndChoosePerson();
            
            if (person == null)
            {
                return;
            }

            if (currentBook.AgeLimit > 0 && !person.Age.HasValue)
            {
                MessageBox.Show($"The {person.ToString()}'s age is not specified.  ",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (person.Age < currentBook.AgeLimit)
            {
                MessageBox.Show($"The {person.ToString()}'s age is less then book's age limit. ",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            ownersInfo.Add(new Book.OwnerInfo
            {
                StartDate = DateTime.Today,
                EndDate = null,
                Employee = ThisApplication.Instance.CurrentEmployee,
                Client = person as Client
            });

            Reinitialize();
            NewOwnerButton.Enabled = false;
        }

        private void ReturnedButton_Click(object sender, EventArgs e)
        {
            ownersInfo.Last().EndDate = DateTime.Today;
            Reinitialize();
            ReturnedButton.Enabled = false;
        }

        private void OwnerInfoButton_Click(object sender, EventArgs e)
        {
            var person = Database.GetById<Person>(currentBook.CurrentOwner.Id);
            var window = new UserFormViewPerson(person);
            window.ShowDialog();
        }
    }
}

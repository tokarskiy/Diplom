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
    public partial class UserFormViewDebtors : Form
    {
        private List<DebtorInfo> info;
        private class DebtorInfo
        {
            public ulong DebtorId { get; set; }
            public ulong BookId { get; set; }
            public DateTime StartDate { get; set; }
            public string BookName { get; set; }
            public string DebtorName { get; set; }
            public string EmployeeName { get; set; }
        };

        public UserFormViewDebtors()
        {
            InitializeComponent();
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginRead();
                IEnumerable<DebtorInfo> query =
                    from book in conn.AllObjects<Book>()
                    where book.CurrentOwner != null
                    //where book.Durability.Value > new TimeSpan(90, 0, 0, 0, 0)
                    select new DebtorInfo
                    {
                        DebtorId = book.CurrentOwner.Id,
                        BookId = book.Id,
                        StartDate = book.Owners.Last().StartDate,
                        BookName = book.Name,
                        DebtorName = book.CurrentOwner.ToString(),
                        EmployeeName = book.Owners.Last().Employee.ToString() ?? "---Empty---"
                    };

                query = query.ToList();

                info = (List<DebtorInfo>)query;
                conn.Commit();

                foreach (var elem in info)
                {
                    infoBox.Items.Add(new ListViewItem(new string[]
                    {
                        elem.BookName,
                        elem.DebtorName,
                        elem.StartDate.ToString("dd/MM/yyyy"),
                        elem.EmployeeName
                    }));
                }
            }
        }

        private void ViewClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                var index = infoBox.SelectedIndices[0];
                if (index < 0)
                {
                    return;
                }

                var person = Database.GetById<Person>(info[index].DebtorId);
                var window = new UserFormViewPerson(person);
                window.ShowDialog();
            }
            catch(ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void BookInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var index = infoBox.SelectedIndices[0];
                if (index < 0)
                {
                    return;
                }

                var book = Database.GetById<Book>(info[index].BookId);
                var window = new UserFormViewBook(book);
                window.ShowDialog();
            }
            catch(ArgumentOutOfRangeException)
            {
                return;
            }
        }
    }
}

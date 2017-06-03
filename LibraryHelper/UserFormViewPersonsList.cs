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
    public partial class UserFormViewPersonsList : Form
    {
        public enum ViewMode
        {
            All, Employees, Clients
        }

        private List<Tuple<string, ulong>> personsData;
        private ViewMode mode;

        private bool Suits(Person person)
        {
            switch (mode)
            {
                case ViewMode.Employees:
                    return person is Employee;
                case ViewMode.Clients:
                    return person is Client;
                default:
                    return true;
            }
        }

        public UserFormViewPersonsList(ViewMode mode = ViewMode.All)
        {
            this.mode = mode;
            InitializeComponent();
            ReinitializePersonsList();
        }

        private void ReinitializePersonsList()
        {
            personsBox.Items.Clear();
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginRead();
                var query =
                    from person in conn.AllObjects<Person>()
                    where Suits(person)
                    orderby person.FirstName, person.LastName
                    select Tuple.Create(person.ToString(), person.Id);

                personsData = query.ToList();

                foreach (var personData in personsData)
                {
                    personsBox.Items.Add(personData.Item1);
                }
                conn.Commit();
            }
        }

        private void ShowEmployeeButton_Click(object sender, EventArgs e)
        {
            var index = personsBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            var person = Database.GetById<Person>(personsData[index].Item2);
            if (person != null)
            {
                var window = new UserFormViewPerson(person);
                window.ShowDialog();
            }

            ReinitializePersonsList();
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            int index = personsBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginUpdate();
                conn.AllObjects<Person>()
                    .FirstOrDefault(x => x.Id == personsData[index].Item2)?
                    .Unpersist(conn);
                conn.Commit();
            }

            ReinitializePersonsList();
        }

        private void personsBox_DoubleClick(object sender, EventArgs e)
        {
            var index = personsBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            var person = Database.GetById<Person>(personsData[index].Item2);
            if (person != null)
            {
                var window = new UserFormViewPerson(person);
                window.ShowDialog();
            }

            ReinitializePersonsList();
        }
    }
}

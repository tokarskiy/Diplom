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
    public partial class UserFormChoosePerson : Form
    {
        private List<Person> persons;
        private Person currentPerson;
        public UserFormChoosePerson(PersonViewType type = PersonViewType.All)
        {
            InitializeComponent();
            IEnumerable<Person> query;
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginRead();
                query = conn.AllObjects<Person>();
                if (type == PersonViewType.ClientsOnly)
                {
                    query = query.Where(x => x is Client);
                }
                if (type == PersonViewType.EmployeesOnly)
                {
                    query = query.Where(x => x is Employee);
                }

                persons = query.ToList();
                conn.Commit();
            }

            personsBox.Items.Add("---Choose a person---");
            foreach (var person in persons)
            {
                personsBox.Items.Add(person.ToString());
            }
            personsBox.SelectedIndex = 0;
            currentPerson = null;

            NewClientButton.Visible = type == PersonViewType.ClientsOnly;
        }

        public Person ShowAndChoosePerson()
        {
            ShowDialog();
            return currentPerson;
        }

        public enum PersonViewType
        {
            All = 0,
            EmployeesOnly,
            ClientsOnly
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            int index = personsBox.SelectedIndex;
            if (index <= 0)
            {
                MessageBox.Show("Choose a person. ",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            currentPerson = persons[index - 1]; //The first line is an empty record
            Close();
        }

        private void NewClientButton_Click(object sender, EventArgs e)
        {
            Hide();
            var window = new UserFormAddClient();
            var client = window.ShowAndAddClient();
            if (client == null)
            {
                Show();
                return;
            }

            currentPerson = client;
            return;
        }
    }
}

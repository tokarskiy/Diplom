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
    public partial class UserFormBirthdayReminder : Form
    {
        private class BirthdayInfo
        {
            public ulong PersonId { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        private Dictionary<Type, List<BirthdayInfo>> birthdaysInfo;
        public UserFormBirthdayReminder()
        {
            InitializeComponent();
            SendQuery();
            FillBoxes();
        }

        private void SendQuery()
        {
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginRead();
                var query =
                    from person in conn.AllObjects<Person>()
                    where person.BirthDate != null
                    let day = person.BirthDate.Value.Day
                    let month = person.BirthDate.Value.Month
                    where day == DateTime.Today.Day && month == DateTime.Today.Month
                    orderby person.FirstName, person.LastName
                    group new BirthdayInfo
                    {
                        PersonId = person.Id,
                        Name = person.FirstName,
                        Age = person.Age.Value
                    }
                    by person.GetType();

                birthdaysInfo = new Dictionary<Type, List<BirthdayInfo>>();
                foreach (var group in query)
                {
                    birthdaysInfo.Add(group.Key, group.ToList());
                }

                conn.Commit();
            }
        }

        private void FillBoxes()
        {
            if (birthdaysInfo.ContainsKey(typeof(Employee)))
            {
                foreach (var employee in birthdaysInfo[typeof(Employee)])
                {
                    EmployeesBox.Items.Add($"{employee.Name}: {employee.Age} years old");
                }
            }
        }

        public void ShowIfBirthdaysExists(bool errorBox = false)
        {
            if (birthdaysInfo.Count != 0)
            {
                ShowDialog();
            }
            else if (errorBox)
            {
                MessageBox.Show("Did not find people who have birthday today. ",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }
        }
    }
}

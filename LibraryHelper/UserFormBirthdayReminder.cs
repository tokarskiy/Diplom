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
        public enum PersonOutType
        {
            Employees, Clients, All
        }

        private class BirthdayInfo
        {
            public ulong PersonId { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        private Dictionary<Type, List<BirthdayInfo>> birthdaysInfo;
        private PersonOutType outType;

        public UserFormBirthdayReminder(PersonOutType type = PersonOutType.All)
        {
            outType = type;
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
                        Name = $"{person.FirstName} {person.LastName}",
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
            foreach (var employee in GetAllBirthdaysInfo())
            {
                EmployeesBox.Items.Add($"{employee.Name}: {employee.Age} years old");
            }
        }

        public void ShowIfBirthdaysExists(bool errorBox = false)
        {
            if (PersonsCount() != 0)
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

        private IEnumerable<BirthdayInfo> GetAllBirthdaysInfo()
        {
            switch (outType)
            {
                case PersonOutType.All:
                    return ClientsInfo.Concat(EmployeesInfo);
                case PersonOutType.Clients:
                    return ClientsInfo;
                case PersonOutType.Employees:
                    return EmployeesInfo;
            }
            return null;
        }

        private IEnumerable<BirthdayInfo> EmployeesInfo => birthdaysInfo.ContainsKey(typeof(Employee)) 
            ? birthdaysInfo[typeof(Employee)] : new List<BirthdayInfo>();

        private IEnumerable<BirthdayInfo> ClientsInfo => birthdaysInfo.ContainsKey(typeof(Client))
            ? birthdaysInfo[typeof(Client)] : new List<BirthdayInfo>();

        private int PersonsCount()
        {
            var employeesCount = birthdaysInfo.ContainsKey(typeof(Employee)) ? birthdaysInfo[typeof(Employee)].Count : 0;
            var clientsCount = birthdaysInfo.ContainsKey(typeof(Client)) ? birthdaysInfo[typeof(Client)].Count : 0;

            return (outType != PersonOutType.Clients ? employeesCount : 0) +
                   (outType != PersonOutType.Employees ? clientsCount : 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityDb;
using VelocityDb.Collection;
using VelocityDb.Session;

namespace LibraryHelper
{   
    public class Person : OptimizedPersistable
    {
        private DateTime? birthDate;
        private VelocityDbList<string> emails;
        private VelocityDbList<string> phones;
        
        public Person() : base()
        {
            emails = new VelocityDbList<string>();
            phones = new VelocityDbList<string>();
        }

        /// <summary>
        ///     Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///     Отчество
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        ///     Дата рождения человека
        /// </summary>
        public DateTime? BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value.HasValue)
                {
                    birthDate = value.Value.Date;
                }
                else
                {
                    birthDate = null;
                }
            }
        }

        /// <summary>
        ///     Возраст человека. Явно установить нельзя, зависит от дня рождения
        ///     и от текущей даты
        /// </summary>
        public int? Age
        {
            get
            {
                if (birthDate == null)
                {
                    return null;
                }

                var today = DateTime.Today;
                int age = today.Year - birthDate.Value.Year;
                if (birthDate > today.AddYears(-age))
                {
                    age--;
                }
                return age;
            }
        }

        /// <summary>
        ///     Список электронных адресов человека
        /// </summary>
        public IReadOnlyCollection<string> Emails
        {
            get
            {
                return emails.ToList().AsReadOnly();
            }
        }

        /// <summary>
        ///     Список телефонных номеров человека
        /// </summary>
        public IReadOnlyCollection<string> Phones
        {
            get
            {
                return phones.ToList().AsReadOnly();
            }
        }

        public void AddEmail(string email)
        {
            emails.Add(email);
        }

        public void AddPhone(string phone)
        {
            phones.Add(phone);
        }

        public void RemoveEmail(string email)
        {
            emails.Remove(email);
        }

        public void RemovePhone(string phone)
        {
            phones.Remove(phone);
        }

        public void RemoveEmailAt(int index)
        {
            emails.RemoveAt(index);
        }

        public void RemovePhoneAt(int index)
        {
            phones.RemoveAt(index);
        }

        public void ClearEmails()
        {
            emails.Clear();
        }

        public void ClearPhones()
        {
            phones.Clear();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public override void Unpersist(SessionBase session)
        {
            var emails = this.emails;
            this.emails = null;
            emails.Unpersist(session);

            var phones = this.phones;
            this.phones = null;
            phones.Unpersist(session);

            base.Unpersist(session);
        }
    }
}

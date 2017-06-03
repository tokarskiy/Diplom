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
    public class Book : OptimizedPersistable
    {
        public class OwnerInfo
        {
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public Client Client { get; set; }
            public Employee Employee { get; set; }

            public TimeSpan Durability
            {
                get
                {
                    return !EndDate.HasValue ? DateTime.Today - StartDate : EndDate.Value - StartDate;
                }
            }

            public bool IsReturned
            {
                get
                {
                    return EndDate != null;
                }
            }
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Author { get; set; }
        public int AgeLimit { get; set; }

        private VelocityDbList<OwnerInfo> ownersInfo;

        public Book()
        {
            ownersInfo = new VelocityDbList<OwnerInfo>();
        }

        public IReadOnlyList<OwnerInfo> Owners
        {
            get
            {
                return ownersInfo.ToList().AsReadOnly();
            }
        }

        public void AddOwnerInfo(OwnerInfo info)
        {
            ownersInfo.Add(info);
        }

        public void RemoveAt(int index)
        {
            ownersInfo.RemoveAt(index);
        }

        public override void Unpersist(SessionBase session)
        {
            this.ownersInfo = null;
            ownersInfo.Unpersist(session);

            base.Unpersist(session);
        }

        public bool IsAvailable
        {
            get
            {
                return ownersInfo.Count != 0 ?
                       ownersInfo.Last().IsReturned :
                       true;
            }
        }

        public Client CurrentOwner
        {
            get
            {
                OwnerInfo last = ownersInfo.LastOrDefault();
                if (last == null)
                {
                    return null;
                }

                if (last.EndDate.HasValue)
                {
                    return null;
                }

                return last.Client;
            }
        }

        public void AddOwnerInfoList(SessionNoServer session, IEnumerable<OwnerInfo> info)
        {
            if (session == null || info == null)
            {
                throw new ArgumentNullException();
            }

            var oinfo = ownersInfo;
            ownersInfo = null;
            oinfo.Unpersist(session);

            ownersInfo = new VelocityDbList<OwnerInfo>();
            foreach (var elem in info)
            {
                ownersInfo.Add(elem);
                session.UpdateObject(elem);
            }
        }

        public TimeSpan? Durability
        {
            get
            {
                var last = ownersInfo.LastOrDefault();
                if (last == null)
                {
                    return null;
                }

                return last.EndDate.HasValue ? null : new TimeSpan?(DateTime.Today - last.StartDate);
            }
        }

        public class BookNotReturnedException : Exception { }
    }
}

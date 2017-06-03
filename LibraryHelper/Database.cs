using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityDb;

namespace LibraryHelper
{
    public static class Database
    {
        public static T GetById<T>(ulong id) where T : OptimizedPersistable
        {
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginRead();
                var ret = conn.AllObjects<T>().FirstOrDefault(x => x.Id == id);
                conn.Commit();
                return ret;
            }
        }
    }
}

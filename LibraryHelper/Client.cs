using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityDb.Collection;

namespace LibraryHelper
{
    public class Client : Person
    {
        public string Code { get; set; }

        public override string ToString()
        {
            return $"[{Code}] {base.ToString()}";
        }
    }

    public static class ClientInformation
    {
        public static IEnumerable<Book> GetCurrentBooks(this Client client)
        {
            IEnumerable<Book> result;
            using (var conn = ThisApplication.Instance.Session)
            {
                conn.BeginRead();
                result =
                    from x in conn.AllObjects<Book>()
                    where x.CurrentOwner.Id == client.Id
                    select x;

                conn.Commit();
            }
            return result.ToList();
        }
    }
}

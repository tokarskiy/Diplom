using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityDb.Session;

namespace LibraryHelper
{
    public class ThisApplication
    {
        private static ThisApplication instance;
        private string databaseName;

        private ThisApplication()
        {
            databaseName = "LibraryDatabase";
            using (var conn = new SessionNoServer(databaseName))
            {
                conn.BeginUpdate();
                conn.Commit();
            }
        }

        /// <summary>
        ///     Instance of program settings 
        /// </summary>
        public static ThisApplication Instance
        {
            get
            {
                return instance ?? (instance = new ThisApplication());
            }
        } 

        public Employee CurrentEmployee { get; set; }
        public string DatabaseName => databaseName ?? String.Empty;
        
        public SessionNoServer Session => new SessionNoServer(databaseName);
    }
}

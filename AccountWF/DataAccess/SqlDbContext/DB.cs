using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace AccountWF.DataAccess.SqlDbContext
{
    public class DB
    {
        private static DB _instance;
        public static DB Database
        {
            get
            {
                if (_instance is null)
                    _instance = new DB();
                return _instance;
            }
        }

        //public List<User> users = new List<User>();
        public string ConnectionString { get; }

        private DB()
        {
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();
            sqlConnectionString.DataSource = "Localhost";
            sqlConnectionString.InitialCatalog = "AccountDB";
            sqlConnectionString.IntegratedSecurity = true;

            ConnectionString = sqlConnectionString.ConnectionString;
        }

    }
}

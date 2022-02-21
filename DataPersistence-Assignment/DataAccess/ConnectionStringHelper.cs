using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersistence_Assignment.DataAccess
{
    public class ConnectionStringHelper
    {
        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = "MURAT-LAPTOP\\SQLEXPRESS";
            sqlConnectionStringBuilder.InitialCatalog = "Chinook";
            sqlConnectionStringBuilder.IntegratedSecurity = true;
            sqlConnectionStringBuilder.TrustServerCertificate = true;

            return sqlConnectionStringBuilder.ConnectionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Persistence
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
            connectionString = "Server=DESKTOP-GV2110Q;Database= MyCompany; integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Utility
{
    public static class Database
    {
        static string connectionString = "server=127.0.0.1;uid=root;pwd=;database=lab_db";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
    }
}

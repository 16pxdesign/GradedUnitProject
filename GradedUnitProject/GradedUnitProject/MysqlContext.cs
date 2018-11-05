using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace GradedUnitProject
{
    class MysqlContext
    {
        MySqlConnection connection;
        

        public MysqlContext()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MysqlContext"].ConnectionString;
            this.connection = new MySqlConnection(connectionString);
        }

        public DataTable getTable()
        {
           
                this.connection.Open();
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "select * from a";
                sql.Connection = this.connection;
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql);
                DataTable table = new DataTable();
                adapter.Fill(table);
                this.connection.Close();
                return table;
   

        }
    }
}

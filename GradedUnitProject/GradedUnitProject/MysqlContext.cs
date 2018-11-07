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
        MySqlConnection connection = null;
        

        public MysqlContext() 
        {

#if DEBUG
            System.Diagnostics.Trace.WriteLine("Mysql reference created");
#endif

            string connectionString = ConfigurationManager.ConnectionStrings["MysqlContext"].ConnectionString;
            this.connection = new MySqlConnection(connectionString);
            try{
                this.connection.Open();
            }
            catch (Exception e){
                throw new Exception("Can`t open connection to database", e);
            }
        }

        ~MysqlContext()
        {

#if DEBUG
            System.Diagnostics.Trace.WriteLine("Mysql reference destroyed");
#endif

            this.connection.Close();
        }

        public DataTable getTable()
        {
                System.Diagnostics.Trace.WriteLine("GetTavble");
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "select * from a";
                sql.Connection = this.connection;
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
    
        }
    }
}

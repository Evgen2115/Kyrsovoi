using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kyrsovoi
{
    class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=Kyrsovoy;Integrated Security=True");


        public void openConnection()
        {

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }



        public void closeConnection()
        {

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return con;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RealEstate
{
    class DBconnection
    {


        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=realestate");
        public MySqlConnection getconnection
        {
            get
            {
                return connection;
            }
        }
        public void openConnection()
        {
            if(connection.State==System.Data.ConnectionState.Closed) //open connection if closed
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) // close connection if opened
            {
                connection.Close();
            }
        }

    }
}

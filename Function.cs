using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RealEstate
{
    class Function
    { DBconnection connection = new DBconnection();

        public Boolean ExecQuery(MySqlCommand command)
        {
            command.Connection = connection.getconnection;
            connection.openConnection();
            if(command.ExecuteNonQuery()==1)
            {
                connection.closeConnection();
                return true;

            }
            else
            {
                connection.closeConnection();
                return true;
            }
        }
        public DataTable getData(MySqlCommand command)
        {
            command.Connection = connection.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}

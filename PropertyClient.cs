using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RealEstate
{
    class PropertyClient
    {
        Function f = new Function();
        private int id;
        private String fname;
        private string lname;
        private string phone;
        private string email;
        private string address;
        public PropertyClient()
        {

        }
        public PropertyClient(int id, string fname, string lname, string phone, string email, string address)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
            this.email = email;
            this.address = address;
        }
        public DataTable getAllclients(string OwnerOrClient)
        {
            String tableName = OwnerOrClient;
            MySqlCommand command = new MySqlCommand("SELECT * FROM `" + tableName + "`");
            return f.getData(command);
        }
        public Boolean insertClient(String ownerORclient, PropertyClient client)
        {
            String tableName = ownerORclient;

            MySqlCommand command = new MySqlCommand("INSERT INTO `" + tableName + "`(`first_name`, `last_name`, `phone`, `email`, `address`) VALUES (@fname,@lname,@phone,@email,@address)");

            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = client.fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = client.lname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = client.phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = client.email;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = client.address;
            return f.ExecQuery(command);

        }
        public Boolean UpdateClient(String ownerORclient, PropertyClient client)
        {
            String tableName = ownerORclient;

            MySqlCommand command = new MySqlCommand("UPDATE `" + tableName + "` SET `first_name`=@fname,`last_name`=@lname,`phone`=@phone,`email`=@email,`address`=@address WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = client.id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = client.fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = client.lname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = client.phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = client.email;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = client.address;
            return f.ExecQuery(command);

        }
        public Boolean DeleteClient(string ownerORclient, PropertyClient client)
        {
            String tableName = ownerORclient;

            MySqlCommand command = new MySqlCommand("DELETE FROM `" + tableName + "` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = client.id;

            return f.ExecQuery(command);

        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RealEstate
{
    class person
    {
        Function f = new Function();
        private int id;
        private String fname;
        private string lname;
        private string phone;
        private string email;
        private string address;
        public person()
        {

        }
        public person(int id,string fname,string lname,string phone,string email,string address)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
            this.email = email;
            this.address = address;
        }
        public DataTable getAllOwners(string OwnerOrClient)  //retrieve all the owners info from the database
        {
            String tableName = OwnerOrClient;
            MySqlCommand command = new MySqlCommand("SELECT * FROM `"+tableName+"`");
            return f.getData(command);
        }
      
        public Boolean insertOwner(String ownerORclient,person p) //insert owner data to the database
        {
            String tableName = ownerORclient;
            
                MySqlCommand command = new MySqlCommand("INSERT INTO `"+tableName+"`(`first_name`, `last_name`, `phone`, `email`, `address`) VALUES (@fname,@lname,@phone,@email,@address)");

               command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = p.fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = p.lname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = p.phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = p.email;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = p.address;
            return f.ExecQuery(command);

        }
        public Boolean UpdateOwner(string ownerORclient, person p) //update owner data
        {
            string tableName = ownerORclient;

            MySqlCommand command = new MySqlCommand("UPDATE `"+tableName+ "` SET `first_name`=@fname,`last_name`=@lname,`phone`=@phone,`email`=@email,`address`=@address WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = p.id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = p.fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = p.lname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = p.phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = p.email;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = p.address;
            return f.ExecQuery(command);

        }
        public Boolean DeleteOwner(string ownerORclient, person p) // delete owner data
        {
            string tableName = ownerORclient;

            MySqlCommand command = new MySqlCommand("DELETE FROM `"+tableName+"` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = p.id;
            
            return f.ExecQuery(command);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace RealEstate
{
    class Approve
    {
        Function f = new Function();
        private int id;
        private string fname;
        private string lname;
        private string phone;
        private string email;
        private string address;
        public Approve()
        {

        }
        public Approve(int id, string fname, string lname, string phone, string email, string address)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
            this.email = email;
            this.address = address;
        }

        public Boolean insertOwner(Approve a) //insert owner data to the database
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `approve`(`first_name`, `last_name`, `phone`, `email`, `address`) VALUES (@first_name,@last_name,@phone,@email,@address)");

            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = a.fname;
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = a.lname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = a.phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = a.email;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = a.address;
            return f.ExecQuery(command);


        }
      
        public DataTable getAllApproved(string approvedowner)  //retrieve all the owners info from the database
        {
            String tableName =approvedowner;
            MySqlCommand command = new MySqlCommand("SELECT * FROM `" + tableName + "`");
            return f.getData(command);
        }
     

    }

}

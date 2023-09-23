using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RealEstate
{
    class ShowMyProperty
    {
        Function f = new Function();
        private int ownerid;
        public ShowMyProperty()
        {

        }
        public ShowMyProperty( int ownerid)
        {
          
            this.ownerid = ownerid;
        }
        public DataTable getAllProperties(ShowMyProperty show)  //retrieve all the owners info from the database
        {
          

            MySqlCommand command = new MySqlCommand("SELECT * FROM `property` WHERE `ownerid`=@ownerid");
            command.Parameters.Add("@ownerid", MySqlDbType.Int32).Value = ownerid;
            return f.getData(command);
        }









    }


}

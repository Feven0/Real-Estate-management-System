using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RealEstate
{
    class propertyType1
    {
        Function f = new Function();
        private int id;
        private String description;
        private string name;
        public propertyType1()
        {

        }
        public propertyType1(int id, string name, string description )
        {
            this.id = id;
            this.name = name;
            this.description = description;
         
        }
        public DataTable getAllTypes(string type)
        {
            String tableName =type;
            MySqlCommand command = new MySqlCommand("SELECT * FROM `" + tableName + "`");
            return f.getData(command);
        }
        public Boolean insertType(String type, propertyType1 ptype)
        {
            String tableName = type;

            MySqlCommand command = new MySqlCommand("INSERT INTO `" + tableName + "`(`Name`, `Description`) VALUES (@name,@description)");
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = ptype.name;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = ptype.description;
       
            return f.ExecQuery(command);

        }
        public Boolean UpdateType(String type, propertyType1 ptype)
        {
            String tableName = type;

            MySqlCommand command = new MySqlCommand("UPDATE `"+tableName+"` SET `Name`=@name,`Description`=@description WHERE id=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = ptype.id;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = ptype.name;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = ptype.description;

            return f.ExecQuery(command);

        }
        public Boolean DeleteType(String proptype, propertyType1 ptype)
        {
            String tableName = proptype;

            MySqlCommand command = new MySqlCommand("DELETE FROM `" + tableName + "` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = ptype.id;

            return f.ExecQuery(command);

        }
    }

}

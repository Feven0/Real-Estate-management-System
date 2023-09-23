using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace RealEstate
{
    class Property
    {
        Function f = new Function();
        private int id;
        private int type;
        private int ownerid;
        private int size;
        private int age;
        private int bedrooms;
        private int bathrooms;
        private string price;
        private string address;
       
        private bool balcony;
       // private bool backyard;
        private bool fireplace;
        private bool garage;
        private bool pool;

        public Property()
        {
          
        }
       
       public Property(int id,int type,int ownerid,int size, string price, string address, int bedrooms, int bathrooms, int age, bool balcony, bool pool, bool garage, bool fireplace)
        {
            this.id = id;
            this.type = type;
            this.ownerid = ownerid;
            this.size = size;
            this.price = price;
            this.address = address;
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;

            this.age = age;
            this.balcony = balcony;
           // this.backyard = backyard;
            this.pool = pool;
            this.garage = garage;
            this.fireplace = fireplace;
         


        }
        public DataTable getAllTypes(string OwnerOrClient)
        {
            string tableName = OwnerOrClient;
            MySqlCommand command = new MySqlCommand("SELECT * FROM `" + tableName + "`");
            return f.getData(command);
        }
        public Boolean insertProperty(Property prop)
        {
           

            MySqlCommand command = new MySqlCommand("INSERT INTO `property`(`type`, `ownerid`, `square_feet`, `price`, `address`, `bedrooms`, `bathrooms`, `age`, `balcony`, `pool`, `garage`, `fireplace`) VALUES (@type,@ownerid,@square_feet,@price,@address,@bedrooms,@bathrooms,@age,@balcony,@pool,@garage,@fireplace)");

            command.Parameters.AddWithValue("@type", prop.type);
            command.Parameters.Add("@ownerid", MySqlDbType.Int32).Value = prop.ownerid;
            command.Parameters.Add("@square_feet", MySqlDbType.Int32).Value = prop.size;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = prop.price;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = prop.address;
            command.Parameters.Add("@bedrooms", MySqlDbType.Int32).Value = prop.bedrooms;
            command.Parameters.Add("@bathrooms", MySqlDbType.Int32).Value = prop.bathrooms;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = prop.age;
           
            command.Parameters.AddWithValue("@balcony", prop.balcony);
           // command.Parameters.AddWithValue("@back_yard", prop.backyard);
            command.Parameters.AddWithValue("@pool", prop.pool);
            command.Parameters.AddWithValue("@garage", prop.garage);
            command.Parameters.AddWithValue("@fireplace", prop.fireplace);
     
            return f.ExecQuery(command);

        }
        public Boolean approvedProperty()
        {


            MySqlCommand command = new MySqlCommand("SELECT * FROM `approve`");

          

            return f.ExecQuery(command);

        }

        public Boolean deleteProperty(int id)
        {


            MySqlCommand command = new MySqlCommand("DELETE FROM `property` WHERE `id`=@id");

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
     

            return f.ExecQuery(command);

        }
        public DataTable getPropertyById(int id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `property` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            return f.getData(command);
        }
        
        
      
    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace RealEstate
{
    class PropertyImage
    {

        Function f = new Function();
        public bool insertImage(int propertyId, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `property_images`( `property_id`, `image`) VALUES (@propertyid,@image)");
            command.Parameters.Add("@propertyid", MySqlDbType.Int32).Value = propertyId;
            command.Parameters.Add("@image", MySqlDbType.LongBlob).Value = picture.ToArray();
          
            f.ExecQuery(command);
            return true;
        }
        public bool deleteImage(int propertyId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `property_images` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = propertyId;

            return f.ExecQuery(command);
        }
        public MemoryStream getImageById(int imageId)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `property_images` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = imageId;
            DataTable table = f.getData(command);
            MemoryStream picture = new MemoryStream((Byte[])table.Rows[0]["image"]);
            return picture;

        }
        public DataTable getPropertyImages(int id)
        {
            return new DataTable();
        }
    }
}
   

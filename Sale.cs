using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RealEstate
{
    class Sale
    {
        private int id;
        private int propertyid;
        private int clientid;
        private DateTime sellingdate;
        private string sellingprice;
        Function f = new Function();
        public Sale(int id,int propertyid,int clientid,DateTime sale_date,string sale_price)
        {
            this.id = id;
            this.propertyid = propertyid;
            this.clientid = clientid;
            this.sellingdate = sale_date;
            this.sellingprice = sale_price;

        }
        public Sale()
        {

        }
        public bool insertSale(Sale sale)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `sale`( `property_id`, `client_id`, `sale_date`, `selling_price`) VALUES (@property_id,@client_id,@sale_date,@selling_price)");

            command.Parameters.Add("@property_id", MySqlDbType.VarChar).Value = sale.propertyid;
            command.Parameters.Add("@client_id", MySqlDbType.VarChar).Value = sale.clientid;
            command.Parameters.Add("@sale_date", MySqlDbType.Date).Value = sale.sellingdate;
            command.Parameters.Add("@selling_price", MySqlDbType.VarChar).Value = sale.sellingprice;
           
            return f.ExecQuery(command);
        }
        public DataTable getSales()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `sale`");
            return f.getData(command);
        }
    }
}

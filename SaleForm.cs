using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RealEstate
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }
        person p = new person();
        Property prop = new Property();
        Sale sale = new Sale();
        Function f = new Function();

        private void SaleForm_Load(object sender, EventArgs e)
        {
            SaleButton.BackColor = Color.DarkGray;
            LoadDatagridviewSales();
            //populate datagridview clients
            MySqlCommand commandGetClients = new MySqlCommand("SELECT `id`, `first_name`, `last_name` FROM `property_client`");
            dataGridViewClients.DataSource = f.getData(commandGetClients);
            //populate datagridview properties

            MySqlCommand commandGetProperties = new MySqlCommand("SELECT `id`,  `ownerid`, `price`, `address` FROM `property`");
            dataGridViewProperty.DataSource = f.getData(commandGetProperties);
          
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
          
               // int id = Convert.ToInt32(textBoxId.Text);
                int propertyId = Convert.ToInt32(textBoxPropertyId.Text);
                int clientId = Convert.ToInt32(textBoxClientId.Text);
                string sellingprice = textBoxSellingPrice.Text;
                DateTime sellingdate = dateTimePickerSale.Value;
                if (sale.insertSale(new Sale(0,propertyId,clientId,sellingdate,sellingprice)))
                {
                    MessageBox.Show("new sale addded", "add client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDatagridviewSales();
                }
                else
                {
                    MessageBox.Show("sale not addded", "add client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
        

    

        private void DataGridViewClients_Click(object sender, EventArgs e)
        {
            textBoxClientId.Text = dataGridViewClients.CurrentRow.Cells[0].Value.ToString();
        }

    

        private void DataGridViewProperty_Click(object sender, EventArgs e)
        {
            textBoxPropertyId.Text = dataGridViewProperty.CurrentRow.Cells[0].Value.ToString();

            textBoxSellingPrice.Text = dataGridViewProperty.CurrentRow.Cells[2].Value.ToString();
        }

        private void Property_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridViewSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
          public void LoadDatagridviewSales()
        {
            dataGridViewSale.DataSource = sale.getSales();
        }
    }
}

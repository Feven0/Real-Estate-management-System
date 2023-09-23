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
    public partial class ClientViewPropertyForm : Form
    {
        public ClientViewPropertyForm()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public DataTable getPropertyById(int id)
        {
            Function f = new Function();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `property` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            return f.getData(command);
        }


        private void SearchId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            //get the property data using the id 

            DataTable propertyData = getPropertyById(id);
            //display the property data using the id
            try
            {
                textBoxOwner.Text = propertyData.Rows[0]["ownerid"].ToString();
                textBoxSize.Text = propertyData.Rows[0]["square_feet"].ToString(); ;
                textBoxPrice.Text = propertyData.Rows[0]["price"].ToString(); ;
                textBoxAddress.Text = propertyData.Rows[0]["address"].ToString(); ;
               
     
                numericUpDownBedrooms.Value = Convert.ToDecimal(propertyData.Rows[0]["bedrooms"]);
                numericUpDownBathrooms.Value = Convert.ToDecimal(propertyData.Rows[0]["bathrooms"]);
                numericUpDownAge.Value = Convert.ToDecimal(propertyData.Rows[0]["age"]); ;
                checkBoxBalcony.Checked = (bool)propertyData.Rows[0]["balcony"];
                checkBoxGarage.Checked = (bool)propertyData.Rows[0]["garage"];
                checkBoxFireplace.Checked = (bool)propertyData.Rows[0]["fireplace"];
                checkBoxPool.Checked = (bool)propertyData.Rows[0]["pool"];
            }
            catch
            {
                if (textBoxId.Text.Trim().Equals(""))
                {
                    MessageBox.Show("This property doesn't exist", "Enter id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Property doesn't exist", "property not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientViewPropertyForm_Load(object sender, EventArgs e)
        {
            buttonProperty.BackColor = Color.DarkGray;
        }
    }
}

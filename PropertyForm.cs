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
    public partial class PropertyForm : Form
    {
        public PropertyForm()
        {
            InitializeComponent();
        }
        Property prop = new Property();




        public void PropertyForm_Load(object sender, EventArgs e)
        {
          
            propertyType1 ptype = new propertyType1();
            comboBoxType.DataSource = ptype.getAllTypes("property_type");
            PropertyButton.BackColor = Color.Gray;
            comboBoxType.DisplayMember = "name";
            comboBoxType.ValueMember = "id";
            comboBoxType.ForeColor = Color.Black;
            comboBoxType.Font = new Font("constantia", 10, FontStyle.Bold, GraphicsUnit.Point);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {


                //int id = Convert.ToInt32(textBoxId.Text);
                int type = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
                int ownerid = Convert.ToInt32(textBoxOwner.Text);
                int size = Convert.ToInt32(textBoxSize.Text);
                string price = textBoxPrice.Text;

                string address = textBoxAddress.Text;
                int bedrooms = (int)numericUpDownBedrooms.Value;
                int bathrooms = (int)numericUpDownBathrooms.Value;

                int age = (int)numericUpDownAge.Value;



                Boolean hasBalcony = checkBoxBalcony.Checked;

                Boolean hasGarage = checkBoxGarage.Checked;
                Boolean hasFireplace = checkBoxFireplace.Checked;
                Boolean hasPool = checkBoxPool.Checked;
                // MessageBox.Show("Balcony " + hasBalcony + " Backyard " + hasBackyard + " Garage " + hasGarage);
               
                    if (verifTextBoxes())
                    {


                        if (prop.insertProperty((new Property(0, type, ownerid, size, price, address, bedrooms, bathrooms, age, hasBalcony, hasPool, hasGarage, hasFireplace))))
                        {
                            MessageBox.Show("new property added", "Add property", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("property not added", "Add property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter the required fields (size , address and price) ", "Add property", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }
            
            catch
            {

                MessageBox.Show("Property Id error", "property not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }


            public void SearchId_Click(object sender, EventArgs e)
        {
            //get the property id
            int id = Convert.ToInt32(textBoxId.Text);
            //get the property data using the id 
         
            DataTable propertyData = prop.getPropertyById(id);
            //display the property data using the id
            try {
                textBoxOwner.Text = propertyData.Rows[0]["ownerid"].ToString();
                textBoxSize.Text = propertyData.Rows[0]["square_feet"].ToString(); ;
                textBoxPrice.Text = propertyData.Rows[0]["price"].ToString(); ;
                textBoxAddress.Text = propertyData.Rows[0]["address"].ToString(); ;
               
                comboBoxType.SelectedValue = propertyData.Rows[0]["type"];
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


        
        private void ButtonRemove_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBoxId.Text);

            if (MessageBox.Show("Are you sure you want to delete this property?", "Delete property", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {


                if (prop.deleteProperty(id))
                {
                    MessageBox.Show("one property removed", "remove property", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("property not removed", "remove property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("no property selected ", "remove property", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

     

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void SelectOwner_Click(object sender, EventArgs e)
        {
            OwnerListForm1 ownersform = new OwnerListForm1();

            ownersform.ShowDialog();
            textBoxOwner.Text = ownersform.DataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        public bool verifTextBoxes()
        {
            String size = textBoxSize.Text.Trim();
            String price = textBoxPrice.Text.Trim();
            String address = textBoxAddress.Text.Trim();
            if (size.Equals("") || price.Equals("") || address.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    
    

        private void ShowAllProperties_Click(object sender, EventArgs e)
        {
          
        }

        private void Property_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

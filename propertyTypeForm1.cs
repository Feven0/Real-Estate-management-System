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
    public partial class propertyTypeForm1 : Form
    {
        public propertyTypeForm1()
        {
            InitializeComponent();
        }
       propertyType1 ptype;
   
        private void PropertyTypeForm1_Load(object sender, EventArgs e)
        {
            propertyTypeButton.BackColor = Color.Gray;
            LoadDatagridviewOwners();
            displayTypesCount();
            dataGridViewOwners.ForeColor = Color.Black;
            dataGridViewOwners.Font = new Font("Arial Rounded MT", 9, GraphicsUnit.Point);

            displayTypesCount();
        }
        private void ButtonAdd_Click_1(object sender, EventArgs e)
        {
            int id = 0;
            String name = textBoxName.Text;
            String description = textBoxDescription.Text;

            ptype = new propertyType1(id, name, description);
            if (verifTextBoxes())
            {


                if (ptype.insertType("property_type", ptype))
                {
                    MessageBox.Show("New property type Added", "Add property type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridviewOwners();
                    displayTypesCount();
                  
                }
                else
                {
                    MessageBox.Show("property type Not Added", "Add property type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter The property First ", "Add property type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
    
        public void LoadDatagridviewOwners()
        {
            ptype = new propertyType1 ();
            dataGridViewOwners.DataSource = ptype.getAllTypes("property_type");
            dataGridViewOwners.ForeColor = Color.Black;
            dataGridViewOwners.Font = new Font("Arial Rounded MT", 8, GraphicsUnit.Point);
        }

        public void displayTypesCount()
        {
            String count = ptype.getAllTypes("property_type").Rows.Count.ToString();
           countTypes.Text = count + " Type(s)";
        }

     

        private void ButtonEdit_Click(object sender, EventArgs e)
        {


            try
            {
                String name = textBoxName.Text;
                String description = textBoxDescription.Text;
                int id = Convert.ToInt32(textBoxId.Text);
                ptype = new propertyType1(id,name,description );
                if (verifTextBoxes())
                {


                    if (ptype.UpdateType("property_type", ptype))
                    {
                        MessageBox.Show("owner Edited", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDatagridviewOwners();
                        displayTypesCount();
                       
                    }
                    else
                    {
                        MessageBox.Show("owner not edited", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter The Owner First ", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("owner id error ", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBoxName.Text;
                String description = textBoxDescription.Text;
                int id = Convert.ToInt32(textBoxId.Text);
                ptype = new propertyType1(id, name, description);
                if (verifTextBoxes())
                {


                    if (ptype.DeleteType("property_type", ptype))
                    {
                        MessageBox.Show("owner removed", "remove owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDatagridviewOwners();
                        displayTypesCount();
                     
                    }
                    else
                    {
                        MessageBox.Show("owner not removed", "remove Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("select The Owner First ", "remove Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("owner id error ", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
          public bool verifTextBoxes()
        {
            String name = textBoxName.Text.Trim();
            String description = textBoxDescription.Text.Trim();
         
            if (name.Equals("") || description.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

   
        public void displayTypeCount()
        {
            String count = ptype.getAllTypes("property_owner").Rows.Count.ToString();
            countTypes.Text = count + " Type(s)";
        }

        private void Property_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridViewOwners_Click_1(object sender, EventArgs e)
        {
            textBoxId.Text = dataGridViewOwners.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewOwners.CurrentRow.Cells[1].Value.ToString();
            textBoxDescription.Text = dataGridViewOwners.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

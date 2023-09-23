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
    public partial class PropertyOwnerForm : Form
    {
        public PropertyOwnerForm()
        {
            InitializeComponent();
        }
        person p;

    
        private void PropertyOwnerForm_Load(object sender, EventArgs e)
        {

            OwnerButton.BackColor = Color.DarkGray;
            LoadDatagridviewOwners();
            displayOwnersCount();

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            int id = 0;
            String fname = textBoxFname.Text;
            String lname = textBoxLname.Text;
            String phone = textBoxPhone.Text;
            String email = textBoxEmail.Text;
            String address = textBoxAddress.Text;
            p = new person(id, fname, lname, phone, email, address);
            if (verifTextBoxes())
            {
              

                if (p.insertOwner("approve", p))
                {
                    MessageBox.Show("New Owner Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridviewOwners();
                    displayOwnersCount();
                }
                else
                {
                    MessageBox.Show("Owner Not Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter The Owner First ", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
           

             /*  
                String fname = textBoxFname.Text;
            String lname = textBoxLname.Text;
            String phone = textBoxPhone.Text;
            String email = textBoxEmail.Text;
            String address = textBoxAddress.Text;
       
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                p = new person(id, fname, lname, phone, email, address);
                if (verifTextBoxes())
                {


                    if (p.UpdateOwner("property_owner", p))
                    {
                        MessageBox.Show("owner Edited", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDatagridviewOwners();
                        displayOwnersCount();
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
            }*/

        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {/*
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                String fname = textBoxFname.Text;
                String lname = textBoxLname.Text;
                String phone = textBoxPhone.Text;
                String email = textBoxEmail.Text;
                String address = textBoxAddress.Text;
                p = new person(id, fname, lname, phone, email, address);
                if (verifTextBoxes())
                {


                    if (p.DeleteOwner("property_owner", p))
                    {
                        MessageBox.Show("owner removed", "remove owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDatagridviewOwners();
                        displayOwnersCount();
                    }
                    else
                    {
                        MessageBox.Show("Owner Not removed", "remove Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("select owner first", "remove Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("id error", "remove Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }

    
        public bool verifTextBoxes()
        {
            String fname = textBoxFname.Text.Trim();
            String lname = textBoxLname.Text.Trim();
            String phone = textBoxPhone.Text.Trim();
            if (fname.Equals("") || lname.Equals("") || phone.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void LoadDatagridviewOwners()
        {
            p = new person();

            dataGridViewOwners.DataSource = p.getAllOwners("approve");

            dataGridViewOwners.ForeColor = Color.Black;
            dataGridViewOwners.Font = new Font("Arial Rounded MT", 9, GraphicsUnit.Point);
        }
        public void displayOwnersCount()
        {
           String count = p.getAllOwners("approve").Rows.Count.ToString();
            countOwners.Text = count + " Owner(s)";
        }

        private void ButtonShowOwnerProperties_Click(object sender, EventArgs e)
        {
            try
            {
                PropertiesListForm plf = new PropertiesListForm();
                int id = Convert.ToInt32(textBoxId.Text);
                MySqlCommand command = new MySqlCommand("SELECT * FROM `property` WHERE `ownerid`=@ownerid");
                command.Parameters.Add("@ownerid", MySqlDbType.Int32).Value = id;
                plf.populateDataGridView(command);
                plf.ShowDialog();
            }
            catch

            {
                MessageBox.Show("enter the owner first", "empty id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          

        }

        private void Property_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void DataGridViewOwners_Click_1(object sender, EventArgs e)
        {

            textBoxId.Text = dataGridViewOwners.CurrentRow.Cells[0].Value.ToString();
            textBoxFname.Text = dataGridViewOwners.CurrentRow.Cells[1].Value.ToString();
            textBoxLname.Text = dataGridViewOwners.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridViewOwners.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewOwners.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewOwners.CurrentRow.Cells[5].Value.ToString();
        }
    }
}

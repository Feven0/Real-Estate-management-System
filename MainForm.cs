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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      

        private void MainForm_Load(object sender, EventArgs e)
        {
            Home.BackColor = Color.Gray;

           
        }

     // display each form when button is clicked

        private void Button4_Click(object sender, EventArgs e)
        {
            propertyTypeForm1 prop = new propertyTypeForm1();
            prop.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ApproveOwnerForm aof = new ApproveOwnerForm();
            aof.Show();
        }

     
        private void Button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void Property_Click(object sender, EventArgs e)
        {
            PropertyForm property = new PropertyForm();
            property.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PropertyImageForm img = new PropertyImageForm();
            img.Show();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            SaleForm sf = new SaleForm();
            sf.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PropertiesListForm plf = new PropertiesListForm();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `property`");

            plf.populateDataGridView(command);
            plf.ShowDialog();

        }
    }
}

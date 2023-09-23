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
    public partial class PropertiesListForm : Form
    {
        public PropertiesListForm()
        {
            InitializeComponent();
        }

        private void PropertiesListForm_Load(object sender, EventArgs e)
        {
            buttonProp.BackColor = Color.DarkGray;
        }
        public void populateDataGridView(MySqlCommand command)
        {
            dataGridView1.RowTemplate.Height = 35;

            Function f = new Function();
         
            dataGridView1.DataSource = f.getData(command);
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.Font = new Font("Arial Rounded MT", 9,  GraphicsUnit.Point);
        }

        private void Property_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonProp_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}

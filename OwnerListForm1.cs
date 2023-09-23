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
    public partial class OwnerListForm1 : Form
    {
        PropertyForm p = new PropertyForm();

        public OwnerListForm1()
        {
            InitializeComponent();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OwnerListForm1_Load(object sender, EventArgs e)
        {
            DataGridView1.RowTemplate.Height = 35;
          
            Function f = new Function();
            MySqlCommand command = new MySqlCommand("SELECT `id`, `first_name`, `last_name` FROM `approve` ");
            DataGridView1.DataSource = f.getData(command);
            DataGridView1.ForeColor = Color.Black;
            DataGridView1.Font = new Font("Arial Rounded MT", 9, GraphicsUnit.Point);
        }
    }
}

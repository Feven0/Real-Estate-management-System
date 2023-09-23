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
    public partial class OwnerViewPropertyForm : Form
    {
        public OwnerViewPropertyForm()
        {
            InitializeComponent();
        }
        public DataTable getPropertyById(int id)
        {
            Function f = new Function();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `property_owner` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            return f.getData(command);
        }


        private void SearchId_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonShowOwnerProperties_Click(object sender, EventArgs e)
        {
            
        }

        private void OwnerViewPropertyForm_Load(object sender, EventArgs e)
        {
            buttonViewProperty.BackColor = Color.DarkGray;
            DataGridView1.RowTemplate.Height = 35;

            Function f = new Function();
            MySqlCommand command = new MySqlCommand("SELECT `id`, `first_name`, `last_name` FROM `approve` ");
            DataGridView1.DataSource = f.getData(command);
            DataGridView1.ForeColor = Color.Black;
            DataGridView1.Font = new Font("Arial Rounded MT", 9, GraphicsUnit.Point);
        }

        private void Property_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

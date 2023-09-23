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
using System.Data;
namespace RealEstate
{
    public partial class ShowMyPropertyForm : Form
    {
        public ShowMyPropertyForm()
        {
            InitializeComponent();
        }
        Function f = new Function();
        ShowMyProperty smp = new ShowMyProperty();
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            int ownerid = Convert.ToInt32(textBoxOwner.Text);

            //  dataGridView1.DataSource = smp.getAllProperties(new ShowMyProperty(ownerid));
            MySqlCommand commandprops = new MySqlCommand("SELECT * FROM `property` WHERE `ownerid`=@ownerid");
            commandprops.Parameters.Add("@ownerid", MySqlDbType.Int32).Value = ownerid;

            dataGridView1.DataSource = f.getData(commandprops);


        }

        private void Property_Click(object sender, EventArgs e)
        {
            Close();

        }

    }
}

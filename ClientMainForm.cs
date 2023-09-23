using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate
{
    public partial class ClientMainForm : Form
    {
        public ClientMainForm()
        {
            InitializeComponent();
        }

        private void Property_Click(object sender, EventArgs e)
        {
            ClientViewPropertyForm cvp = new ClientViewPropertyForm();
            cvp.Show();
        }

        private void ClientMainForm_Load(object sender, EventArgs e)
        {
          Home.BackColor = Color.Gray;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ImageSliderForm isf = new ImageSliderForm();
            isf.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PropertyStatusForm psf = new PropertyStatusForm();
            psf.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PropertyClientForm pcf = new PropertyClientForm();
            pcf.Show();
        }
    }
}

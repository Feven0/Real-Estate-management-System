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
    public partial class OwnerMainForm : Form
    {
        public OwnerMainForm()
        {
            InitializeComponent();
        }

        private void TextBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void OwnerMainForm_Load(object sender, EventArgs e)
        {
            Home.BackColor = Color.DarkGray;
        }
       

        private void ButtonShowOwnerProperties_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OwnerViewPropertyForm ovpf = new OwnerViewPropertyForm();
            ovpf.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            PropertyOwnerForm owner = new PropertyOwnerForm();
            owner.Show();
        }

        private void Property_Click(object sender, EventArgs e)
        {
            PropertyForm pf = new PropertyForm();
            pf.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            PropertyImageForm pif = new PropertyImageForm();
            pif.Show();
        }

        private void OwnerButton_Click(object sender, EventArgs e)
        {
            ShowMyPropertyForm smpf = new ShowMyPropertyForm();
            smpf.Show();
        }
    }
}

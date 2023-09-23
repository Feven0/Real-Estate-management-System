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
    public partial class ApproveOwnerForm : Form
    {
        Approve a = new Approve();
        public ApproveOwnerForm()
        {
            InitializeComponent();
        }

        private void ApproveOwnersForm_Click(object sender, EventArgs e)
        {
            int id = 0;
            String fname = textBoxFname.Text;
            String lname = textBoxLname.Text;
            String phone = textBoxPhone.Text;
            String email = textBoxEmail.Text;
            String address = textBoxAddress.Text;
         


            if (a.insertOwner(new Approve(id, fname, lname, phone, email, address)))
            {
                MessageBox.Show("owner approved", "Approve Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayOwnersCount();
            }
            else
            {
                MessageBox.Show("Owner Not approved", "Approve owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        person p;
        private void ApproveOwnerForm_Load(object sender, EventArgs e)
        {
            buttonStatus.BackColor = Color.DarkGray;
            LoadDatagridviewOwners();
            displayOwnersCount();
        }

        private void Property_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridViewOwners_Click(object sender, EventArgs e)
        {

            textBoxId.Text = dataGridViewOwners.CurrentRow.Cells[0].Value.ToString();
            textBoxFname.Text = dataGridViewOwners.CurrentRow.Cells[1].Value.ToString();
            textBoxLname.Text = dataGridViewOwners.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridViewOwners.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewOwners.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewOwners.CurrentRow.Cells[5].Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }
        public void displayOwnersCount()
        {

            string count = a.getAllApproved("approve").Rows.Count.ToString();
            button1.Text = count + " Approved Owner(s)";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }
        public bool verifTextBoxes()
        {
            string fname = textBoxFname.Text.Trim();
            string lname = textBoxLname.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
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
          person  p = new person();

            dataGridViewOwners.DataSource = p.getAllOwners("approve");

            dataGridViewOwners.ForeColor = Color.Black;
            dataGridViewOwners.Font = new Font("Arial Rounded MT", 9, GraphicsUnit.Point);
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void DataGridViewOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

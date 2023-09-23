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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
     

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            Function f = new Function();
            if (textBoxPassword.Text != " "  || textBoxUsername.Text != " ")
            {

                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                string confirm = textBoxConfirm.Text;
            
                string choose;
                choose = comboBoxChoose.Text;
                if (textBoxPassword.Text == textBoxConfirm.Text)
                {

                    if (choose == "owner")
                    {
                        MySqlCommand command = new MySqlCommand("INSERT INTO `owner`(`username`, `password`, `confirm_password`) VALUES (@username,@password,@confirm)");
                        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                        command.Parameters.Add("@confirm", MySqlDbType.VarChar).Value = confirm;
                        DataTable table = f.getData(command);
                        MessageBox.Show("sign up completed", "sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                     if(choose=="client")
                    {

                        MySqlCommand command = new MySqlCommand("INSERT INTO `client`(`username`, `password`, `confirm_password`) VALUES (@username,@password,@confirm)");
                        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                        command.Parameters.Add("@confirm", MySqlDbType.VarChar).Value = confirm;
                        DataTable table = f.getData(command);
                        MessageBox.Show("sign up completed", "sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("you need to choose from the sign up option ", "choose sign up option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("password doesn't match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientOwnerLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GoToSignIn_Click(object sender, EventArgs e)
        {
            LoginForm colf = new LoginForm();
            colf.Show();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

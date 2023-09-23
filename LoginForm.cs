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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public Boolean checkFields()
        {
            checkUsername.Visible = false; //asteriks are hidden unless we enter the wrong username
            checkPassword.Visible = false;   //asteriks are hidden unless we enter the wrong password
            if (textBoxUsername.Text.Trim().Equals("") && textBoxPassword.Text.Trim().Equals(""))    //if username and password is empty
            {

                checkUsername.Visible = true;    //show asteriks for both
                checkPassword.Visible = true;

                return false;
            }
            else if (textBoxUsername.Text.Trim().Equals(""))  //if username is empty   
            {
                checkUsername.Visible = true;   //show asteriks for username only


                return false;
            }
            else if (textBoxPassword.Text.Trim().Equals(""))   //if password is empty
            {
                checkPassword.Visible = true;  //show asteriks for password only
                return false;
            }

            else
            {
                return true;
            }
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string choose;
            choose = comboBoxChoose.Text;
            Function f = new Function();
            if (checkFields()) //check for the above condition
            {
                //username and password of the admin
                if (choose == "owner")
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `owner` WHERE username=@user AND password=@pass");
                    command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
                    DataTable table = f.getData(command);
                    if (table.Rows.Count > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        OwnerMainForm omf = new OwnerMainForm();
                        omf.Show();
                    }
                    else
                    {
                        validity.Visible = true; //validity is the message displayed when the password doesn't match the username
                    }
                   
                

                }
                else if(choose=="client")

                {

                    MySqlCommand command = new MySqlCommand("SELECT * FROM `client` WHERE username=@user AND password=@pass");
                    command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
                    DataTable table = f.getData(command);
                    if (table.Rows.Count > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        ClientMainForm cmf = new ClientMainForm();
                        cmf.Show();
                    }
                    else
                    {
                        validity.Visible = true; //validity is the message displayed when the password doesn't match the username
                    }

                 
                }
                else if (choose == "admin")
                {
                 
                  
                        //username and password of the admin
                        MySqlCommand command = new MySqlCommand("SELECT * FROM `admin` WHERE username=@user AND password=@123");
                        command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
                        command.Parameters.Add("@123", MySqlDbType.VarChar).Value = password;
                        DataTable table = f.getData(command);
                        if (table.Rows.Count > 0)
                        {
                            this.DialogResult = DialogResult.OK;
                        MainForm main = new MainForm();
                        main.Show();
                        }
                        else
                        {
                            validity.Visible = true; //validity is the message displayed when the password doesn't match the username
                        }
                }
                
                else
                {
                    MessageBox.Show("you need to choose from the sign up option ", "choose sign up option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Login failed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }































        private void GoToSignIn_Click(object sender, EventArgs e)
        {
         
        }

        private void GoToSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.Show();
        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

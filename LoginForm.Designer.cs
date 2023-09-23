namespace RealEstate
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoToSignUp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkPassword = new System.Windows.Forms.Label();
            this.validity = new System.Windows.Forms.Label();
            this.checkUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 44);
            this.label3.TabIndex = 12;
            this.label3.Text = "USER LOGIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.GoToSignUp);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBoxChoose);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBoxUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkPassword);
            this.panel2.Controls.Add(this.validity);
            this.panel2.Controls.Add(this.checkUsername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ButtonLogin);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Location = new System.Drawing.Point(53, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 476);
            this.panel2.TabIndex = 13;
            // 
            // GoToSignUp
            // 
            this.GoToSignUp.AutoSize = true;
            this.GoToSignUp.BackColor = System.Drawing.Color.Transparent;
            this.GoToSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToSignUp.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToSignUp.ForeColor = System.Drawing.Color.Green;
            this.GoToSignUp.Location = new System.Drawing.Point(347, 436);
            this.GoToSignUp.Name = "GoToSignUp";
            this.GoToSignUp.Size = new System.Drawing.Size(59, 18);
            this.GoToSignUp.TabIndex = 21;
            this.GoToSignUp.Text = "Sign up";
            this.GoToSignUp.Click += new System.EventHandler(this.GoToSignUp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(194, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Create an account";
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxChoose.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChoose.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Items.AddRange(new object[] {
            "owner",
            "client",
            "admin"});
            this.comboBoxChoose.Location = new System.Drawing.Point(397, 324);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(148, 24);
            this.comboBoxChoose.TabIndex = 18;
            this.comboBoxChoose.Text = "  owner,client or admin";
            this.comboBoxChoose.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChoose_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealEstate.Properties.Resources.pngtree_user_login_or_authenticate_icon_on_gray_background_flat_icon_ve_png_image_1786166;
            this.pictureBox1.Location = new System.Drawing.Point(198, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxUsername.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxUsername.Location = new System.Drawing.Point(170, 183);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(221, 40);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.TextBoxUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(54, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // checkPassword
            // 
            this.checkPassword.AutoSize = true;
            this.checkPassword.BackColor = System.Drawing.Color.Transparent;
            this.checkPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPassword.ForeColor = System.Drawing.Color.Red;
            this.checkPassword.Location = new System.Drawing.Point(400, 246);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(29, 37);
            this.checkPassword.TabIndex = 8;
            this.checkPassword.Text = "*";
            this.checkPassword.Visible = false;
            // 
            // validity
            // 
            this.validity.AutoSize = true;
            this.validity.BackColor = System.Drawing.Color.Transparent;
            this.validity.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validity.ForeColor = System.Drawing.Color.Red;
            this.validity.Location = new System.Drawing.Point(166, 383);
            this.validity.Name = "validity";
            this.validity.Size = new System.Drawing.Size(240, 21);
            this.validity.TabIndex = 9;
            this.validity.Text = "Invalid Username and Password";
            this.validity.Visible = false;
            // 
            // checkUsername
            // 
            this.checkUsername.AutoSize = true;
            this.checkUsername.BackColor = System.Drawing.Color.Transparent;
            this.checkUsername.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUsername.ForeColor = System.Drawing.Color.Red;
            this.checkUsername.Location = new System.Drawing.Point(398, 183);
            this.checkUsername.Name = "checkUsername";
            this.checkUsername.Size = new System.Drawing.Size(31, 43);
            this.checkUsername.TabIndex = 7;
            this.checkUsername.Text = "*";
            this.checkUsername.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(54, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonLogin.FlatAppearance.BorderSize = 2;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(169, 303);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(222, 45);
            this.ButtonLogin.TabIndex = 5;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(170, 246);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(221, 38);
            this.textBoxPassword.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "User Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label checkPassword;
        private System.Windows.Forms.Label validity;
        private System.Windows.Forms.Label checkUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxChoose;
        private System.Windows.Forms.Label GoToSignUp;
        private System.Windows.Forms.Label label6;
    }
}
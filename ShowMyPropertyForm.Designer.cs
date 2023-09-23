namespace RealEstate
{
    partial class ShowMyPropertyForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.OwnerButton = new System.Windows.Forms.Button();
            this.Property = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.OwnerButton);
            this.panel3.Controls.Add(this.Property);
            this.panel3.Location = new System.Drawing.Point(-76, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 464);
            this.panel3.TabIndex = 22;
            // 
            // OwnerButton
            // 
            this.OwnerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OwnerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OwnerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.OwnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OwnerButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerButton.ForeColor = System.Drawing.Color.White;
            this.OwnerButton.Location = new System.Drawing.Point(61, 177);
            this.OwnerButton.Name = "OwnerButton";
            this.OwnerButton.Size = new System.Drawing.Size(210, 70);
            this.OwnerButton.TabIndex = 7;
            this.OwnerButton.Text = " show my properties";
            this.OwnerButton.UseVisualStyleBackColor = false;
            // 
            // Property
            // 
            this.Property.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Property.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Property.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Property.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Property.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Property.ForeColor = System.Drawing.Color.White;
            this.Property.Location = new System.Drawing.Point(44, 82);
            this.Property.Name = "Property";
            this.Property.Size = new System.Drawing.Size(217, 71);
            this.Property.TabIndex = 6;
            this.Property.Text = "Back";
            this.Property.UseVisualStyleBackColor = false;
            this.Property.Click += new System.EventHandler(this.Property_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-76, -31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 124);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(301, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your dream home!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealEstate.Properties.Resources.Screenshot_20210613_152708_Chrome;
            this.pictureBox1.Location = new System.Drawing.Point(76, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(544, 139);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 39);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Search";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxOwner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOwner.Location = new System.Drawing.Point(341, 139);
            this.textBoxOwner.Multiline = true;
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(186, 39);
            this.textBoxOwner.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(217, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Owner Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(305, 149);
            this.dataGridView1.TabIndex = 27;
            // 
            // ShowMyPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(677, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ShowMyPropertyForm";
            this.Text = "ShowMyPropertyForm";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button OwnerButton;
        private System.Windows.Forms.Button Property;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
namespace RealEstate
{
    partial class PropertiesListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Property = new System.Windows.Forms.Button();
            this.buttonProp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1118, 401);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(175, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 112);
            this.panel1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(184, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your dream home!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealEstate.Properties.Resources.Screenshot_20210613_152708_Chrome;
            this.pictureBox1.Location = new System.Drawing.Point(1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.Property);
            this.panel3.Controls.Add(this.buttonProp);
            this.panel3.Location = new System.Drawing.Point(1, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 391);
            this.panel3.TabIndex = 42;
            // 
            // Property
            // 
            this.Property.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Property.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Property.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Property.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Property.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Property.ForeColor = System.Drawing.Color.White;
            this.Property.Location = new System.Drawing.Point(0, 75);
            this.Property.Name = "Property";
            this.Property.Size = new System.Drawing.Size(190, 69);
            this.Property.TabIndex = 7;
            this.Property.Text = "  Back";
            this.Property.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Property.UseVisualStyleBackColor = false;
            this.Property.Click += new System.EventHandler(this.Property_Click);
            // 
            // buttonProp
            // 
            this.buttonProp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonProp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonProp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProp.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProp.ForeColor = System.Drawing.Color.White;
            this.buttonProp.Location = new System.Drawing.Point(0, 173);
            this.buttonProp.Name = "buttonProp";
            this.buttonProp.Size = new System.Drawing.Size(190, 69);
            this.buttonProp.TabIndex = 5;
            this.buttonProp.Text = " Property List";
            this.buttonProp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProp.UseVisualStyleBackColor = false;
            this.buttonProp.Click += new System.EventHandler(this.ButtonProp_Click);
            // 
            // PropertiesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "PropertiesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties List";
            this.Load += new System.EventHandler(this.PropertiesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonProp;
        private System.Windows.Forms.Button Property;
    }
}
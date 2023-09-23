namespace RealEstate
{
    partial class OwnerViewPropertyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Property = new System.Windows.Forms.Button();
            this.buttonViewProperty = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your dream home!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(164, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 93);
            this.panel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealEstate.Properties.Resources.Screenshot_20210613_152708_Chrome;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.Property);
            this.panel3.Controls.Add(this.buttonViewProperty);
            this.panel3.Location = new System.Drawing.Point(-39, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 453);
            this.panel3.TabIndex = 37;
            // 
            // Property
            // 
            this.Property.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Property.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Property.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Property.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Property.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Property.ForeColor = System.Drawing.Color.White;
            this.Property.Location = new System.Drawing.Point(37, 85);
            this.Property.Name = "Property";
            this.Property.Size = new System.Drawing.Size(215, 64);
            this.Property.TabIndex = 7;
            this.Property.Text = " Back";
            this.Property.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Property.UseVisualStyleBackColor = false;
            this.Property.Click += new System.EventHandler(this.Property_Click);
            // 
            // buttonViewProperty
            // 
            this.buttonViewProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonViewProperty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonViewProperty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonViewProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewProperty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProperty.ForeColor = System.Drawing.Color.White;
            this.buttonViewProperty.Location = new System.Drawing.Point(3, 173);
            this.buttonViewProperty.Name = "buttonViewProperty";
            this.buttonViewProperty.Size = new System.Drawing.Size(225, 69);
            this.buttonViewProperty.TabIndex = 1;
            this.buttonViewProperty.Text = "    Approved Owners";
            this.buttonViewProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewProperty.UseVisualStyleBackColor = false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.GridColor = System.Drawing.Color.White;
            this.DataGridView1.Location = new System.Drawing.Point(172, 82);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(471, 402);
            this.DataGridView1.TabIndex = 40;
            // 
            // OwnerViewPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 481);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "OwnerViewPropertyForm";
            this.Text = "OwnerViewPropertyForm";
            this.Load += new System.EventHandler(this.OwnerViewPropertyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonViewProperty;
        private System.Windows.Forms.Button Property;
        internal System.Windows.Forms.DataGridView DataGridView1;
    }
}
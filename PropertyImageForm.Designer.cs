namespace RealEstate
{
    partial class PropertyImageForm
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
            this.listBoxImagesId = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OnSelectImage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PropertyImageButton = new System.Windows.Forms.Button();
            this.Property = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPropertyImage = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPropertyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxImagesId
            // 
            this.listBoxImagesId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxImagesId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxImagesId.FormattingEnabled = true;
            this.listBoxImagesId.ItemHeight = 20;
            this.listBoxImagesId.Location = new System.Drawing.Point(334, 261);
            this.listBoxImagesId.Name = "listBoxImagesId";
            this.listBoxImagesId.Size = new System.Drawing.Size(145, 184);
            this.listBoxImagesId.TabIndex = 3;
            this.listBoxImagesId.Click += new System.EventHandler(this.ListBoxImagesId_Click);
            this.listBoxImagesId.SelectedIndexChanged += new System.EventHandler(this.ListBoxImagesId_SelectedIndexChanged);
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
            this.buttonAdd.Location = new System.Drawing.Point(620, 477);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(260, 36);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(334, 478);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(145, 36);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(331, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Images List";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // OnSelectImage
            // 
            this.OnSelectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OnSelectImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OnSelectImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.OnSelectImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.OnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnSelectImage.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnSelectImage.ForeColor = System.Drawing.Color.White;
            this.OnSelectImage.Location = new System.Drawing.Point(620, 180);
            this.OnSelectImage.Name = "OnSelectImage";
            this.OnSelectImage.Size = new System.Drawing.Size(260, 37);
            this.OnSelectImage.TabIndex = 19;
            this.OnSelectImage.Text = "Select Image";
            this.OnSelectImage.UseVisualStyleBackColor = false;
            this.OnSelectImage.Click += new System.EventHandler(this.OnSelectImage_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.PropertyImageButton);
            this.panel3.Controls.Add(this.Property);
            this.panel3.Location = new System.Drawing.Point(1, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 444);
            this.panel3.TabIndex = 35;
            // 
            // PropertyImageButton
            // 
            this.PropertyImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PropertyImageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PropertyImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PropertyImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PropertyImageButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyImageButton.ForeColor = System.Drawing.Color.White;
            this.PropertyImageButton.Location = new System.Drawing.Point(-4, 198);
            this.PropertyImageButton.Name = "PropertyImageButton";
            this.PropertyImageButton.Size = new System.Drawing.Size(196, 66);
            this.PropertyImageButton.TabIndex = 8;
            this.PropertyImageButton.Text = "  Property images";
            this.PropertyImageButton.UseVisualStyleBackColor = false;
            // 
            // Property
            // 
            this.Property.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Property.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Property.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Property.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Property.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Property.ForeColor = System.Drawing.Color.White;
            this.Property.Location = new System.Drawing.Point(0, 103);
            this.Property.Name = "Property";
            this.Property.Size = new System.Drawing.Size(192, 66);
            this.Property.TabIndex = 6;
            this.Property.Text = "   Back";
            this.Property.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Property.UseVisualStyleBackColor = false;
            this.Property.Click += new System.EventHandler(this.Property_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(181, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your dream home!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(179, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 95);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealEstate.Properties.Resources.Screenshot_20210613_152708_Chrome;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPropertyImage
            // 
            this.pictureBoxPropertyImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxPropertyImage.Location = new System.Drawing.Point(620, 255);
            this.pictureBoxPropertyImage.Name = "pictureBoxPropertyImage";
            this.pictureBoxPropertyImage.Size = new System.Drawing.Size(260, 192);
            this.pictureBoxPropertyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPropertyImage.TabIndex = 4;
            this.pictureBoxPropertyImage.TabStop = false;
            this.pictureBoxPropertyImage.Click += new System.EventHandler(this.PictureBoxPropertyImage_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.DimGray;
            this.labelName.Location = new System.Drawing.Point(234, 263);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 23);
            this.labelName.TabIndex = 41;
            this.labelName.Text = "Name:";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.Azure;
            this.textBoxId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(320, 180);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(186, 44);
            this.textBoxId.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(512, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 44);
            this.button1.TabIndex = 42;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PropertyImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.OnSelectImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBoxPropertyImage);
            this.Controls.Add(this.listBoxImagesId);
            this.MaximizeBox = false;
            this.Name = "PropertyImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Property Image";
            this.Load += new System.EventHandler(this.PropertyImageForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPropertyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxImagesId;
        private System.Windows.Forms.PictureBox pictureBoxPropertyImage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OnSelectImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Property;
        private System.Windows.Forms.Button PropertyImageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button button1;
    }
}
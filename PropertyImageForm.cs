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
using System.IO;
namespace RealEstate
{
    public partial class PropertyImageForm : Form
    {
        public PropertyImageForm()
        {
            InitializeComponent();
        }
        PropertyImage propertyImage = new PropertyImage();
        Function f = new Function();
        private void PropertyImageForm_Load(object sender, EventArgs e)
        {
           
            PropertyImageButton.BackColor = Color.Gray;
          

        }

        private void OnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter="Choose Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPropertyImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

            int propertyId = Convert.ToInt32(textBoxId.Text);
                MemoryStream pic = new MemoryStream();
                pictureBoxPropertyImage.Image.Save(pic, pictureBoxPropertyImage.Image.RawFormat);
                if (propertyImage.insertImage(propertyId, pic))
                {
                    MessageBox.Show("new Image added to this property", "Add Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Image not added", "Add Image", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

          

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            
            try

            {
                int propertyId = Convert.ToInt32(listBoxImagesId.SelectedValue);
                if (MessageBox.Show("do you want to remove this image", "remove image", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (propertyImage.deleteImage(propertyId))
                    {
                        MessageBox.Show("image deleted", "remove image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("image not deleted", "remove image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
        }

        private void Property_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        private void ListBoxType_Click(object sender, EventArgs e)
        {
           

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
         
        }

        private void ListBoxImagesId_Click(object sender, EventArgs e)
        {
           int picId = Convert.ToInt32(listBoxImagesId.SelectedValue);
            pictureBoxPropertyImage.Image = Image.FromStream(propertyImage.getImageById(picId));
        }

     

        private void ListBoxImagesId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectOwner_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {   
            MySqlCommand commandpropsImages = new MySqlCommand("SELECT * FROM `property_images` WHERE `property_id`=@pid");
            int propertyId = Convert.ToInt32(textBoxId.Text);
            commandpropsImages.Parameters.Add("@pid", MySqlDbType.Int32).Value = propertyId;
            listBoxImagesId.DataSource = f.getData(commandpropsImages);
            listBoxImagesId.DisplayMember = "id";
            listBoxImagesId.ValueMember = "id";
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxPropertyImage_Click(object sender, EventArgs e)
        {

        }
    }
    }


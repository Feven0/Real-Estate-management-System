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
    public partial class ImageSliderForm : Form
    {
        public ImageSliderForm()
        {
            InitializeComponent();
        }
        PropertyImage propertyImage = new PropertyImage();
        Function f = new Function();

        private void ImageSliderForm_Load(object sender, EventArgs e)
        {

          
            listBoxType.Font = new Font("Arial Rounded MT", 9, GraphicsUnit.Point);
            Function f = new Function();
            MySqlCommand commandprops = new MySqlCommand("SELECT `id`,`address`,`age` FROM `property`");
            dataGridView1.DataSource = f.getData(commandprops);
            MySqlCommand commandtypes = new MySqlCommand("SELECT * FROM `property_type`");
            listBoxType.DataSource = f.getData(commandtypes);
            listBoxType.DisplayMember = "name";
            listBoxType.ValueMember = "id";
            listBoxType.SelectedItem = null;
            listBoxImagesId.SelectedItem = null;
            dataGridView1.ClearSelection();
        }
    
       

        private void ListBoxImagesId_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            MySqlCommand commandpropsImages = new MySqlCommand("SELECT * FROM `property_images` WHERE `property_id`=@pid");
            int propertyId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            commandpropsImages.Parameters.Add("@pid", MySqlDbType.Int32).Value = propertyId;
            listBoxImagesId.DataSource = f.getData(commandpropsImages);
            listBoxImagesId.DisplayMember = "id";
            listBoxImagesId.ValueMember = "id";
        }

        private void ListBoxImagesId_Click_1(object sender, EventArgs e)
        {
            int picId = Convert.ToInt32(listBoxImagesId.SelectedValue);
            pictureBoxPropertyImage.Image = Image.FromStream(propertyImage.getImageById(picId));
            labelInfo.Visible = false;
        }

        private void ListBoxType_Click(object sender, EventArgs e)
        {
            MySqlCommand commandprops = new MySqlCommand("SELECT `id`, `age`, `address`  FROM `property` WHERE `type`=@type");
            int typeId = Convert.ToInt32(listBoxType.SelectedValue);
            commandprops.Parameters.Add("@type", MySqlDbType.Int32).Value = typeId;
            dataGridView1.DataSource = f.getData(commandprops);
        }

        private void ListBoxImagesId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

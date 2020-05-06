using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MAPMAClient.Controller;
using MAPMAClient.EscRef;

namespace MAPMAClient.GUI
{
    public partial class CreateEscapeRoom : Form
    {
        private List<MAPMAClient.Model.EscapeRoom> escapeRooms;
        public CreateEscapeRoom ( )
        {
            InitializeComponent();
        }

        private void CreateEscapeRoom_Load ( object sender, EventArgs e )
        {
            UpdateEscapeRoomList();
        }

        byte[] ConvertImgToBinary (Image img )
        {

            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        private void btnCreateEscapeRoom_Click(object sender, EventArgs e) {
            EscapeRoomCtr esC = new EscapeRoomCtr();
            decimal MaxC = decimal.Parse(txtMaxClearTime.Text);
            decimal ClTi = decimal.Parse(txtCleanTime.Text);
            decimal Pri = decimal.Parse(txtPrice.Text);
            decimal rating = 0;
            int Emp = int.Parse(txtEmployeeID.Text);
            byte[] img = ConvertImgToBinary(pbEscaperoom.Image);
            esC.CreateEscapeRoom(txtName.Text ,txbDescription.Text, MaxC, ClTi, Pri, rating, Emp, img);
            UpdateEscapeRoomList();
        }

        private void UpdateEscapeRoomList ( )
        {
            EscapeRoomCtr esc = new EscapeRoomCtr();
            escapeRooms = esc.GetAllForOwner();
            dataGridView1.DataSource = escapeRooms;
        }

        private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {
            //try
            //{
            //    var SelectedRow = dataGridView1.SelectedRows[0].DataBoundItem as EscapeRoom;
            //    lblShowEscapeRoomID.Text = SelectedRow.escapeRoomID.ToString();
            //    txtName.Text = SelectedRow.name;
            //    txbDescription.Text = SelectedRow.description;
            //    txtMaxClearTime.Text = SelectedRow.maxClearTime.ToString();
            //    txtCleanTime.Text = SelectedRow.cleanTime.ToString();
            //    txtPrice.Text = SelectedRow.price.ToString();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            MAPMAClient.Model.EscapeRoom escapeRoom = escapeRooms.ElementAt(index);
            Update_Room ur = new Update_Room(escapeRoom);
            ur.Show();
            this.Hide();
        }

        private void btnBackCreateEscapeRoom_Click(object sender, EventArgs e) {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void btnDoneCreateEscapeRoom_Click(object sender, EventArgs e) {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void btnFindPicture_Click ( object sender, EventArgs e )
        {
            string fileName;
            using(OpenFileDialog ofd = new OpenFileDialog() {Filter="JPEG|*.jpg", ValidateNames = true, Multiselect = false})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    pbEscaperoom.Image = Image.FromFile(fileName);
                }
            }
        }
    }
}

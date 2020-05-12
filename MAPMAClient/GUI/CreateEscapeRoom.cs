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
        private MAPMAClient.Model.EscapeRoom er;

        public CreateEscapeRoom ( )
        {
            InitializeComponent();
            UpdateEscapeRoomList();
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
            if (txtName.Text.Trim().Equals("")) 
            {
                lblErrorName.Visible = true;
                lblErrorName.Text = "Mangler input";
            }
            else if (txbDescription.Text.Trim().Equals(""))
            {
                lblErrorDesciption.Visible = true;
                lblErrorDesciption.Text = "Mangler input";
            }
            else if (txtMaxClearTime.Text.Trim().Equals(""))
            {
                lblErrorMaxClearTime.Visible = true;
                lblErrorMaxClearTime.Text = "Mangler input";
            }
            else if (txtCleanTime.Text.Trim().Equals(""))
            {
                lblErrorCleanTime.Visible = true;
                lblErrorCleanTime.Text = "Mangler input";
            }
            else if (txtPrice.Text.Trim().Equals(""))
            {
                lblErrorPrice.Visible = true;
                lblErrorPrice.Text = "Mangler input";
            }
            else if (txtEmployeeID.Text.Trim().Equals(""))
            {
                lblErrorEmployee.Visible = true;
                lblErrorEmployee.Text = "Mangler input";
            }
            else if (pbEscaperoom.Image == null)
            {
                lblErrorImage.Visible = true;
            }
            else {
                decimal MaxC = decimal.Parse(txtMaxClearTime.Text);
                decimal ClTi = decimal.Parse(txtCleanTime.Text);
                decimal Pri = decimal.Parse(txtPrice.Text);
                decimal rating = 0;
                int Emp = int.Parse(txtEmployeeID.Text);
                byte[] img = ConvertImgToBinary(pbEscaperoom.Image);
                esC.CreateEscapeRoom(txtName.Text, txbDescription.Text, MaxC, ClTi, Pri, rating, Emp, img);
                EmptyText();
                UpdateEscapeRoomList();
                    }
        }

        private void EmptyText()
        {
            lblErrorName.Visible = false;
            lblErrorDesciption.Visible = false;
            lblErrorMaxClearTime.Visible = false;
            lblErrorCleanTime.Visible = false;
            lblErrorPrice.Visible = false;
            lblErrorEmployee.Visible = false;
            lblErrorImage.Visible = false;


            txtMaxClearTime.Text = "";
            txtCleanTime.Text = "";
            txtPrice.Text = "";
            txtEmployeeID.Text = "";
            pbEscaperoom.Image = null;
            txtName.Text = "";
            txbDescription.Text = "";
        }

        private void UpdateEscapeRoomList ( )
        {
            EscapeRoomCtr esc = new EscapeRoomCtr();
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            escapeRooms = esc.GetAllForOwner();

            dt.Columns.Add("Escaperoom", typeof(string));
            dt.Columns.Add("Pris", typeof(decimal));
            dt.Columns.Add("Medarbejder", typeof(string));
            dt.Columns.Add("Max Gennemførsels tid", typeof(decimal));
            dt.Columns.Add("Klargøringstid", typeof(decimal));

            foreach (var EscapeRoom in escapeRooms) {
                dt.Rows.Add(EscapeRoom.Name,  EscapeRoom.Price, EscapeRoom.Emp.FirstName + " " + EscapeRoom.Emp.LastName, EscapeRoom.MaxClearTime, EscapeRoom.CleanTime);
            }

            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
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

        private void btnDeleteEscapeRoom_Click(object sender, EventArgs e)
        {
            EscapeRoomCtr erctr = new EscapeRoomCtr();
            DialogResult result;
            result = MessageBox.Show("Du er ved at slette " + er.Name + ".  er du sikker","slet Escaperoom", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(result == System.Windows.Forms.DialogResult.Yes) {
                erctr.Delete(er.EscapeRoomID);
            }
            
            UpdateEscapeRoomList();

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            er = escapeRooms.ElementAt(index);
        }

        private void txtMaxClearTime_TextChanged ( object sender, EventArgs e )
        {
            try
            {
                if (txtMaxClearTime.Text.Equals("")) {

                }
                else {
                    decimal.Parse(txtMaxClearTime.Text);
                    lblErrorMaxClearTime.Visible = false;
                }
            }
            catch(FormatException FE)
            {
                txtMaxClearTime.Text = "";
                lblErrorMaxClearTime.Visible = true;
                lblErrorMaxClearTime.Text = "Skal være et tal";
            }
        }

        private void txtCleanTime_TextChanged ( object sender, EventArgs e )
        {
            try
            {
                if (txtCleanTime.Text.Equals("")) {

                }
                else {
                    decimal.Parse(txtCleanTime.Text);
                    lblErrorCleanTime.Visible = false;
                }
            }
            catch (FormatException FE)
            {
                txtCleanTime.Text = "";
                lblErrorCleanTime.Visible = true;
                lblErrorCleanTime.Text = "Skal være et tal";
            }
        }

        private void txtPrice_TextChanged ( object sender, EventArgs e )
        {
            try
            {
                if (txtPrice.Text.Equals("")) {

                }
                else {
                    decimal.Parse(txtPrice.Text);
                    lblErrorPrice.Visible = false;
                }
            }
            catch (FormatException FE)
            {
                txtPrice.Text = "";
                lblErrorPrice.Visible = true;
                lblErrorPrice.Text = "Skal være et tal";
            }
        }

        private void txtEmployeeID_TextChanged ( object sender, EventArgs e )
        {
            try
            {
                if (txtEmployeeID.Text.Equals("")) {

                }
                else {
                    int.Parse(txtEmployeeID.Text);
                    lblErrorEmployee.Visible = false;
                }
            }
            catch (FormatException FE)
            {
                txtEmployeeID.Text = "";
                lblErrorEmployee.Visible = true;
                lblErrorEmployee.Text = "Skal være et tal";
            }
        }
    }
}
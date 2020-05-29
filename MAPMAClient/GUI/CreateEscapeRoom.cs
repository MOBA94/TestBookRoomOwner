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
    /// <summary>
    /// <author>
    /// Mick O. B. Andersen
    /// Anders S. Brygger
    /// Peter S. Clausen
    /// Anders B. Larsen
    /// Mads G. Ranzau
    /// </author>
    /// </summary>
    public partial class CreateEscapeRoom : Form
    {
        private List<MAPMAClient.Model.EscapeRoom> escapeRooms;
        private MAPMAClient.Model.EscapeRoom er;

        /// <summary>
        /// Opens CreateEscapeRoom and runs the methode UpdateEscaoeRoomList();
        /// </summary>
        public CreateEscapeRoom ( )
        {
            InitializeComponent();
            UpdateEscapeRoomList();

        }

        /// <summary>
        /// Runs the UpdateEscapeRoomList()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateEscapeRoom_Load ( object sender, EventArgs e )
        {
            UpdateEscapeRoomList();
        }

        /// <summary>
        /// Converts the image to binary
        /// </summary>
        /// <param name="img"></param>
        /// <returns> ms.ToArray(); </returns>
        byte[] ConvertImgToBinary (Image img )
        {

            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        /// <summary>
        /// Checks for empty textfields and if none, then it calls "CreateEscapeRoom", "EmptyText" and "UpdateEscapeRoomList"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Sets the error labels to false and sets textfields to empty
        /// </summary>
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

        /// <summary>
        /// Updates the dataGridView so new escaperooms will be insertet
        /// </summary>
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
            dt.Columns.Add("id", typeof(int));

            foreach (var EscapeRoom in escapeRooms) {
                dt.Rows.Add(EscapeRoom.Name,  EscapeRoom.Price, EscapeRoom.Emp.FirstName + " " + EscapeRoom.Emp.LastName, EscapeRoom.MaxClearTime, EscapeRoom.CleanTime, EscapeRoom.EscapeRoomID);
            }

            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            dataGridView1.Columns["id"].Visible = false;
        }

        /// <summary>
        /// Finds the doubleclicked escaperoom and sends it over to Update_Room and hides itself 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            int id = (int)dataGridView1[5, index].Value;
            int i = 0;
            bool found = false;
            MAPMAClient.Model.EscapeRoom escapeRoom = null;

            while (i < escapeRooms.Count && !found) {
                if (escapeRooms.ElementAt(i).EscapeRoomID == id) {
                    escapeRoom = escapeRooms.ElementAt(i);
                    found = true;
                }
                else {
                    i++;
                }
            }

            if (escapeRoom != null) {
                Update_Room ur = new Update_Room(escapeRoom);
                ur.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Hides CreateEscapeRoom form and shows a new "MainMenu();" (mm)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackCreateEscapeRoom_Click(object sender, EventArgs e) {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        /// <summary>
        /// Hides CreateEscapeRoom form and shows a new "MainMenu();" (mm), but used for the Done botton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoneCreateEscapeRoom_Click(object sender, EventArgs e) {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        /// <summary>
        /// The botton click on find picture, opens a dialog where you can find local pictures, then it set it on the escaperoom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Delete botton for escaperoom, shows a message box with a yes/no, if yes then calls erctr.Delete, last it calls "UpdateEscapeRoomList()"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Finds the clicked escaperoom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            er = escapeRooms.ElementAt(index);
        }

        /// <summary>
        /// Checks textbox for valid input for MaxClearTime, if empty it gives a error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Checks textbox for valid input for CleanTime, if empty it gives a error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Checks textbox for valid input for Price, if empty it gives a error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Checks textbox for valid input for EmployeeID, if empty it gives a error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAPMAClient.Controller;
using MAPMAClient.EscRef;

namespace MAPMAClient.GUI
{
    public partial class CreateEscapeRoom : Form
    {
        public CreateEscapeRoom ( )
        {
            InitializeComponent();
        }

        private void CreateEscapeRoom_Load ( object sender, EventArgs e )
        {
            UpdateEscapeRoomList();
        }

        private void btnCreateEscapeRoom_Click ( object sender, EventArgs e )
        {
            EscapeRoomCtr esC = new EscapeRoomCtr();
            decimal MaxC = decimal.Parse(txtMaxClearTime.Text);
            decimal ClTi = decimal.Parse(txtCleanTime.Text);
            decimal Pri = decimal.Parse(txtPrice.Text);
            decimal rating = 0;
            int Emp = int.Parse(txtEmployeeID.Text);
            esC.CreateEscapeRoom(txtName.Text ,txbDescription.Text, MaxC, ClTi, Pri, rating, Emp);
            UpdateEscapeRoomList();
        }

        private void UpdateEscapeRoomList ( )
        {
            EscapeRoomCtr esc = new EscapeRoomCtr();
            dataGridView1.DataSource = esc.GetAllForOwner();
        }

        private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {
            try
            {
                var SelectedRow = dataGridView1.SelectedRows[0].DataBoundItem as EscapeRoom;
                lblShowEscapeRoomID.Text = SelectedRow.escapeRoomID.ToString();
                txtName.Text = SelectedRow.name;
                txbDescription.Text = SelectedRow.description;
                txtMaxClearTime.Text = SelectedRow.maxClearTime.ToString();
                txtCleanTime.Text = SelectedRow.cleanTime.ToString();
                txtPrice.Text = SelectedRow.price.ToString();
            }
            catch (Exception)
            {

                throw;
            }
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
    }
}

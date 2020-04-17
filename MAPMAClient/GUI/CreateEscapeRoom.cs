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


        }
    }
}

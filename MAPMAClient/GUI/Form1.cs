using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAPMAClient.ServiceLayer;
using MAPMAClient.EscRef;

namespace MAPMAClient.GUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        ////private void button1_Click(object sender, EventArgs e) {
        ////    this.lbxEsc.Items.Clear();
        ////    EscapeRoomServices es = new EscapeRoomServices();
        ////    //List<EscapeRoom> escapeRooms = es.GetAllForOwner();


        ////    foreach (EscapeRoom escapeRoom in escapeRooms) {
        ////        this.lbxEsc.Items.Add(escapeRoom.name);
        ////    }

        ////}

        private void button2_Click(object sender, EventArgs e) {
            EscapeRoomServices es = new EscapeRoomServices();
            int num = int.Parse(txtID.Text);
            lblEsc.Text = es.GetForOwner(num).Name;
        }
    }
}

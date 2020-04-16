using MAPMA.Controller;
using MAPMA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAPMAServiceLayers;


namespace MAPMA.GUI
{
    public partial class Test : Form
    {
        public Test ( )
        {
            InitializeComponent();
        }

        private void Button1_Click ( object sender, EventArgs e )
        {
            EscapeRoomCtr erc = new EscapeRoomCtr();

            foreach (EscapeRoom er in erc.GetAllForOwner()) {
                listBox1.Items.Add(er.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            EscapeRoomCtr erc = new EscapeRoomCtr();
            int num = int.Parse(txtId.Text);
            label1.Text = erc.GetForOwner(num).Name;
        }
    }
}

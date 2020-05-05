using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAPMAClient.GUI {
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
        }

        private void btnMMCreateBooking_Click(object sender, EventArgs e) {
            CreateBooking cb = new CreateBooking();                      
            cb.Show();
            this.Hide();

        }

        private void btnMMCreateEscapeRoom_Click(object sender, EventArgs e) {
            CreateEscapeRoom ce = new CreateEscapeRoom();
            ce.Show();
            this.Hide();
        }
    }
}

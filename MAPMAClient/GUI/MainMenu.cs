using MAPMAClient.Controller;
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

        private BookingCtr bc;
        private EscapeRoomCtr erc;
        private DataTable dt;
        private BindingSource bs;

        public MainMenu() {
            InitializeComponent();
            bc = new BookingCtr();
            erc = new EscapeRoomCtr();
            LoadDataGridView();
        }

        private void LoadDataGridView() {
            dt = new DataTable();
            bs = new BindingSource();

            dt.Columns.Add("Escaperoom", typeof(string));
            dt.Columns.Add("Antal bookinger", typeof(int));
            dt.Columns.Add("Rating", typeof(decimal));            

            FillDataSource();

            bs.DataSource = dt;
            dgvStatistic.DataSource = bs;
            dgvStatistic.AutoResizeColumns();
            dgvStatistic.AutoResizeRows();
            dgvStatistic.Sort(dgvStatistic.Columns["Antal bookinger"], ListSortDirection.Descending);

        }

        private void FillDataSource() {
            List<Model.EscapeRoom> escapeRooms;
            List<int> escapeRoomId = new List<int>();
            
            escapeRooms = erc.GetAllForOwner();

            foreach (Model.EscapeRoom er in escapeRooms) {
                escapeRoomId.Add(er.EscapeRoomID);
            }

            foreach (int id in escapeRoomId) {
                List<Model.Booking> books = bc.GetAllOneRoom(id);
                if (books.Count() != 0) {
                    dt.Rows.Add(books[0].Er.Name, books.Count(), books[0].Er.Rating);
                }
            }
            
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

        private void btnReadBookings_Click ( object sender, EventArgs e )
        {
            ReadBooking rb = new ReadBooking();
            rb.Show();
            this.Hide();
        }

        private void txbSearch_TextChanged ( object sender, EventArgs e )
        {
            bs.Filter = string.Format("Escaperoom LIKE '%{0}%'", txbSearch.Text);
        }

        private void txbSearch_MouseClick ( object sender, MouseEventArgs e )
        {
            if (txbSearch.Text.Equals("søg")){
                txbSearch.ResetText();
            }
        }
    }
}

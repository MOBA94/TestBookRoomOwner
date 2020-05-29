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
    /// <summary>
    /// <author>
    /// Mick O. B. Andersen
    /// Anders S. Brygger
    /// Peter S. Clausen
    /// Anders B. Larsen
    /// Mads G. Ranzau
    /// </author>
    /// </summary>
    public partial class MainMenu : Form {

        private BookingCtr bc;
        private EscapeRoomCtr erc;
        private DataTable dt;
        private BindingSource bs;

        /// <summary>
        /// Opens MainMenu and runs LoadDataGridView()
        /// </summary>
        public MainMenu() {
            InitializeComponent();
            bc = new BookingCtr();
            erc = new EscapeRoomCtr();
            LoadDataGridView();
        }

        /// <summary>
        /// Makes the colums then calls FillDataSource
        /// </summary>
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

        /// <summary>
        /// Finds all the bookings from all the escaperooms and adds them to datasource
        /// </summary>
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

        /// <summary>
        /// Shows CreateBooking and hides itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Shows ReadBooking and hides itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadBookings_Click ( object sender, EventArgs e )
        {
            ReadBooking rb = new ReadBooking();
            rb.Show();
            this.Hide();
        }

        /// <summary>
        /// Search function on escaperoom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbSearch_TextChanged ( object sender, EventArgs e )
        {
            bs.Filter = string.Format("Escaperoom LIKE '%{0}%'", txbSearch.Text);
        }

        /// <summary>
        /// When the searchfield is clicked it checks if the field is equels("søg") if it is it runs ResetText()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbSearch_MouseClick ( object sender, MouseEventArgs e )
        {
            if (txbSearch.Text.Equals("søg")){
                txbSearch.ResetText();
            }
        }
    }
}

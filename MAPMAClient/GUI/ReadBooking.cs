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

    public partial class ReadBooking : Form
    {

        private DataTable dt;
        private BindingSource bs;
        private List<MAPMAClient.Model.Booking> bookings;

        /// <summary>
        /// Opens ReadBooking and runs UpdateBookingList()
        /// </summary>
        public ReadBooking ( )
        {
            InitializeComponent();
            UpdateBookingList();
        }

        /// <summary>
        /// Adds the columns and sets in the bookings
        /// </summary>
        private void UpdateBookingList ( )
        {
            BookingCtr book = new BookingCtr();
            dt = new DataTable();
            bs = new BindingSource();
            bookings = book.GetAll();

            dt.Columns.Add("Escaperoom", typeof(string));
            dt.Columns.Add("Tidspunkt for booking", typeof(TimeSpan));
            dt.Columns.Add("Dato for booking", typeof(DateTime));
            dt.Columns.Add("Antal Personer", typeof(int));
            dt.Columns.Add("Brugernavn", typeof(string));
            dt.Columns.Add("Medarbejder", typeof(string));
            dt.Columns.Add("id", typeof(int));


            foreach (var Booking in bookings) {
                if (Booking.Date >= DateTime.Now.Date)
                {
                    dt.Rows.Add(Booking.Er.Name, Booking.BookingTime, Booking.Date.ToShortDateString(), Booking.AmountOfPeople, Booking.Cus.Username, Booking.Emp.FirstName + Booking.Emp.LastName, Booking.Id);
                }
            }

            bs.DataSource = dt;
            dgvAllBookings.DataSource = bs;
            dgvAllBookings.Columns["id"].Visible = false;


        }

        /// <summary>
        /// Search function for an username
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbSerchReadBooking_TextChanged ( object sender, EventArgs e )
        {
            bs.Filter = string.Format("Brugernavn LIKE '%{0}%'", txbSerchReadBooking.Text);
        }

        /// <summary>
        /// Shows MainMenu (mm) and closes itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseReadBooking_Click ( object sender, EventArgs e )
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        /// <summary>
        /// Opens Edit_Delete with the doubleclicked booking and hides itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAllBookings_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            int index = e.RowIndex;
            int id = (int)dgvAllBookings[6, index].Value;
            int i = 0;
            bool found = false;
            MAPMAClient.Model.Booking book = null;

            while (i < bookings.Count && !found) {
                if (bookings.ElementAt(i).Id == id) {
                    book = bookings.ElementAt(i);
                    found = true;
                }
                else {
                    i++;
                }
            }

            if (book != null) {
                Edit_Delete ed = new Edit_Delete(book);
                ed.Show();
                this.Hide();
            }
        }
    }
}

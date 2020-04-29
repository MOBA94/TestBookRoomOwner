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
    
    public partial class ReadBooking : Form
    {

        private DataTable dt;
        private BindingSource bs;
        private List<MAPMAClient.Model.Booking> bookings;

        public ReadBooking ( )
        {
            InitializeComponent();
            UpdateBookingList();
        }


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

            foreach (var Booking in bookings) {
                dt.Rows.Add(Booking.Er.Name, Booking.BookingTime, Booking.Date.ToShortDateString(), Booking.AmountOfPeople, Booking.Cus.Username, Booking.Emp.FirstName + Booking.Emp.LastName);
            }

            bs.DataSource = dt;
            dgvAllBookings.DataSource = bs;


        }


        private void txbSerchReadBooking_TextChanged ( object sender, EventArgs e )
        {
            bs.Filter = string.Format("Brugernavn LIKE '%{0}%'", txbSerchReadBooking.Text);
        }

        private void btnCloseReadBooking_Click ( object sender, EventArgs e )
        {
            this.Close();
        }


        private void dgvAllBookings_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            int index = e.RowIndex;
            MAPMAClient.Model.Booking book = bookings.ElementAt(index);
            Edit_Delete ed = new Edit_Delete(book);
            ed.Show();
            this.Hide();
        }
    }
}

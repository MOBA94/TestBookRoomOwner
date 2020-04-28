using MAPMAClient.Model;
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
    public partial class Edit_Delete : Form
    {
        public Booking book { get; set; }

        public Edit_Delete ()
        {
            InitializeComponent();
            FillLabels();
        }

        private void btnDelete_Click ( object sender, EventArgs e )
        {

        }

        private void btnCancel_Click ( object sender, EventArgs e )
        {

        }

        private void FillLabels() {
            string aop = Convert.ToString(book.AmountOfPeople);
            lblAmountOfPeopleDelete.Text = aop;
            string bt = Convert.ToString(book.BookingTime);
            lblBookingTimeDelete.Text = bt;
            string dt = Convert.ToString(book.Date);
            lblDateDelete.Text = dt;
            lblEmployeeNameDelete.Text = book.Emp.FirstName + book.Emp.LastName;
            lblEscaperoomDelete.Text = book.Er.Name;
            lblFirstNameDelete.Text = book.Cus.FirstName;
            lblLastNameDelete.Text = book.Cus.LastName;
            lblMailDelete.Text = book.Cus.Mail;
            lblPhoneDelete.Text = book.Cus.Phone;
            lblUsernameDelete.Text = book.Cus.Username;
        }
    }
}

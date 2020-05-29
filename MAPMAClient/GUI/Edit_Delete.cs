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
using MAPMAClient.Controller;

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
    public partial class Edit_Delete : Form
    {
        private Booking book;
        private Booking updatetBook;
        private List<Employee> employees;
        private List<EscapeRoom> escapeRooms;
        private List<TimeSpan> bookingTimes;

        /// <summary>
        /// Opens Edit_Delete runs FillLabels(book) with the choosen booking
        /// </summary>
        /// <param name="booking"></param>
        public Edit_Delete (Booking booking)
        {
            InitializeComponent();
            book = booking;
            updatetBook = book;
            FillLabels(book);
            mcUpdateBooking.MinDate = DateTime.Now.Date;
        }

        /// <summary>
        /// The Delete botton, deletes the booking then closes and shows ReadBooking, if lblAmountOFPeopleDelete.Visible == false then it runs DeleteFirstClick()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click ( object sender, EventArgs e )
        {
            if (lblAmountOfPeopleDelete.Visible == false) {
                DeleteFirstClick();
            }
            else {
                BookingCtr bookctr = new BookingCtr();
                bookctr.Delete(book.Cus, book.Er, book.Date, book.Emp, book.AmountOfPeople, book.BookingTime);
                ReadBooking rb = new ReadBooking();
                rb.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Closes Edit_Delete and shows ReadBooking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click ( object sender, EventArgs e )
        {
            ReadBooking rb = new ReadBooking();
            rb.Show();
            this.Close();
            
        }

        /// <summary>
        /// Shows deletelabels and hides updateboxes and calls FillLabels(book);
        /// </summary>
        private void DeleteFirstClick() {
            lblAmountOfPeopleDelete.Visible = true;
            lblBookingTimeDelete.Visible = true;
            lblDateDelete.Visible = true;
            lblEscaperoomDelete.Visible = true;
            lblEmployeeNameDelete.Visible = true;
            cbEmployee.Visible = false;
            cbEscaperoom.Visible = false;
            cbBookingTime.Visible = false;
            tbAmountOfPeople.Visible = false;
            mcUpdateBooking.Visible = true;
            
            FillLabels(book);

        }

        /// <summary>
        /// Takes input from the booking and fills the labels
        /// </summary>
        /// <param name="book"></param>
        private void FillLabels(Booking book) {
            string aop = Convert.ToString(book.AmountOfPeople);
            lblAmountOfPeopleDelete.Text = aop;
            string bt = Convert.ToString(book.BookingTime);
            lblBookingTimeDelete.Text = bt;
            string dt = Convert.ToString(book.Date);
            lblDateDelete.Text = dt;
            lblEmployeeNameDelete.Text = book.Emp.FirstName + " " + book.Emp.LastName;
            lblEscaperoomDelete.Text = book.Er.Name;
            lblFirstNameDelete.Text = book.Cus.FirstName;
            lblLastNameDelete.Text = book.Cus.LastName;
            lblMailDelete.Text = book.Cus.Mail;
            lblPhoneDelete.Text = book.Cus.Phone;
            lblUsernameDelete.Text = book.Cus.Username;
        }

        /// <summary>
        /// If tbAmountOfPeople.Visible is false then it runs UpdateFirstClick(), LoadCBEmployee and LoadCBEscapeRoom()
        /// Then it checks if AmountOfPeople is larger than 0 the methode Update runs and it shows ReadBooking and closes itself
        /// If AmountOfPeople is not larger than 0 it shows errorelabel and sets the message in the label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click ( object sender, EventArgs e )
        {
            if (tbAmountOfPeople.Visible == false) {
                UpdateFirstClick();
                LoadCBEmployee();
                LoadCBEscapeRoom();
            }
            else {
                BookingCtr bc = new BookingCtr();
                if (updatetBook.AmountOfPeople > 0) {                    
                    bc.Update(updatetBook.Cus, updatetBook.Er, updatetBook.Date, updatetBook.Emp, updatetBook.AmountOfPeople, updatetBook.BookingTime, updatetBook.Id);
                    ReadBooking rb = new ReadBooking();
                    rb.Show();
                    this.Close();
                }
                else {
                    lblErrorAmountOfPeople.Text = "må ikke være 0";
                    lblErrorAmountOfPeople.Show();
                }
            }
        }

        /// <summary>
        /// Fills combobox with Employees
        /// </summary>
        private void LoadCBEmployee() {
            EmployeeCtr empct = new EmployeeCtr();
            employees = new List<Employee>();
            employees = empct.GetAll();
            cbEmployee.Items.Clear();

            foreach (Employee emp in employees) {
                cbEmployee.Items.Add(emp.FirstName + " " + emp.LastName);
            }
            cbEmployee.SelectedItem = book.Emp.FirstName + " " + book.Emp.LastName;
        }

        /// <summary>
        /// Fills combobox with Ecaperooms
        /// </summary>
        private void LoadCBEscapeRoom() {
            EscapeRoomCtr erCtr = new EscapeRoomCtr();
            escapeRooms = new List<EscapeRoom>();
            escapeRooms = erCtr.GetAllForOwner();
            cbEscaperoom.Items.Clear();

            foreach (EscapeRoom er in escapeRooms) {
                cbEscaperoom.Items.Add(er.Name);
            }
            cbEscaperoom.SelectedItem = book.Er.Name;
        }

        /// <summary>
        /// Fills combobox with avalible times
        /// </summary>
        private void LoadCBBookingTime()
        {
            EscapeRoomCtr erCtr = new EscapeRoomCtr();
            bookingTimes = new List<TimeSpan>();
            bookingTimes = erCtr.FreeTimes(book.Er.EscapeRoomID, book.Date);
            cbBookingTime.Items.Clear();

            foreach (TimeSpan ts in bookingTimes) {
                cbBookingTime.Items.Add(ts);
            }
            cbBookingTime.ResetText();
        }

        /// <summary>
        /// Hides labels and shows combo and text-boxes, then runs FillTBUpdate()
        /// </summary>
        private void UpdateFirstClick()
        {
            lblAmountOfPeopleDelete.Visible = false;
            lblBookingTimeDelete.Visible = false;
            lblDateDelete.Visible = false;
            lblEscaperoomDelete.Visible = false;
            lblEmployeeNameDelete.Visible = false;
            cbEmployee.Visible = true;
            cbEscaperoom.Visible = true;
            cbBookingTime.Visible = true;
            tbAmountOfPeople.Visible = true;
            mcUpdateBooking.Visible = true;
            FillTBUpdate();
        }

        /// <summary>
        /// Sets amount of people and booking date
        /// </summary>
        private void FillTBUpdate() {
            tbAmountOfPeople.Text = Convert.ToString(book.AmountOfPeople);
            mcUpdateBooking.SelectionStart = book.Date;
        }

        /// <summary>
        /// Updates booking times and the new date is set as the choosen date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mcUpdateBooking_DateChanged ( object sender, DateRangeEventArgs e )
        {
            book.Date = mcUpdateBooking.SelectionRange.Start;
            LoadCBBookingTime();
        }

        /// <summary>
        /// Sets the info from the choosen escaperoom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEscaperoom_SelectedIndexChanged ( object sender, EventArgs e )
        {
            bool found = false;
            int i = 0;

            while (i < escapeRooms.Count && !found) {
                if (escapeRooms.ElementAt(i).Name.Equals(cbEscaperoom.SelectedItem)) {
                    updatetBook.Er = escapeRooms.ElementAt(i);
                    found = true;
                }
                else {
                    i++;
                }
            }
            LoadCBBookingTime();
        }

        /// <summary>
        /// Sets the info from the choosen escaperoom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEmployee_SelectedIndexChanged ( object sender, EventArgs e )
        {
            bool found = false;
            int i = 0;

            while (i < employees.Count && !found) {
                string name = employees.ElementAt(i).FirstName + " " + employees.ElementAt(i).LastName;
                if (name.Equals(cbEmployee.SelectedItem)) {
                    updatetBook.Emp = employees.ElementAt(i);
                    found = true;
                }
                else {
                    i++;
                }
            }
        }

        /// <summary>
        /// Checks tbAmountOfPeople for valid data, if the data is invalid its shows the error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbAmountOfPeople_TextChanged ( object sender, EventArgs e )
        {
            try {
                updatetBook.AmountOfPeople = int.Parse(tbAmountOfPeople.Text);
                lblErrorAmountOfPeople.Hide();
            }
            catch (FormatException FE) {
                tbAmountOfPeople.Text = "";
                lblErrorAmountOfPeople.Text = "Skal være et tal";
                lblErrorAmountOfPeople.Show();
            }
        }

        /// <summary>
        /// Sets the info from the choosen bookingTime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBookingTime_SelectedIndexChanged ( object sender, EventArgs e )
        {
            bool found = false;
            int i = 0;

            while (i < bookingTimes.Count && !found) {
                if (bookingTimes.ElementAt(i).Equals(cbBookingTime.SelectedItem)) {
                    updatetBook.BookingTime = bookingTimes.ElementAt(i);
                    found = true;
                }
                else {
                    i++;
                }
            }
        }
    }
}

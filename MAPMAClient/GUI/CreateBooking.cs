using MAPMAClient.Controller;
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

namespace MAPMAClient.GUI {
    public partial class CreateBooking : Form {

        private int AmountOfPeople;
        private CustomerCtr Cusctr;
        private EscapeRoomCtr ERCtr;
        private BookingCtr BookCtr;
        private EmployeeCtr EmpCtr;
        private Customer Cus;
        private List<EscapeRoom> escapeRooms;
        private EscapeRoom EsR;
        private TimeSpan TimeForBooking;
        private DateTime DateForBooking;
        private List<TimeSpan> freeTimes;


        public CreateBooking() {
            InitializeComponent();
            Cusctr = new CustomerCtr();
            ERCtr = new EscapeRoomCtr();
            BookCtr = new BookingCtr();
            EmpCtr = new EmployeeCtr();
            escapeRooms = new List<EscapeRoom>();
            CreateBooking_Load();
            calBookTime.MinDate = DateTime.Now.Date;
        }

        private void CreateBooking_Load() {
            escapeRooms = ERCtr.GetAllForOwner();
            cobNameER.Items.Clear();

            foreach (EscapeRoom er in escapeRooms) {
                cobNameER.Items.Add(er.Name);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cobNameER_SelectedIndexChanged(object sender, EventArgs e) {
            bool found = false;
            int i = 0;
            EsR = new EscapeRoom();
            cobNameER.BackColor = Color.White;
            cobNameER.ForeColor = Color.Black;

            while (i < escapeRooms.Count && !found) {
                if (escapeRooms.ElementAt(i).Name.Equals(cobNameER.SelectedItem)) {
                    EsR = escapeRooms.ElementAt(i);
                    found = true;
                }
                else {
                    i++;
                }
            }
            changeEscapeRoomLabels();
            calBookTime.Enabled = true;
        }

        /// <summary>
        /// Changes the labels so it has the info for the selected escaperoom
        /// </summary>
        private void changeEscapeRoomLabels() {
            string price = Convert.ToString(EsR.Price);
            lblPriceRead.Text = price;
            string rating = Convert.ToString(EsR.Rating);
            lblRatingRead.Text = rating;
            string clearTime = Convert.ToString(EsR.MaxClearTime);
            lblClearTimeRead.Text = clearTime;
            lblBookEscapeRoomNameRead.Text = EsR.Name;

        }

        private void calBookTime_DateChanged(object sender, DateRangeEventArgs e) {
            DateForBooking = calBookTime.SelectionRange.Start;
            string date = Convert.ToString(DateForBooking.ToShortDateString());
            lblBookDateRead.Text = date;

            Freetimes();
        }

        /// <summary>
        /// Check the ecaperoom on the selected date and adds the avaliable times
        /// </summary>
        private void Freetimes() {
            cobFreeTimes.Items.Clear();
            freeTimes = ERCtr.FreeTimes(EsR.EscapeRoomID, DateForBooking);
            foreach (TimeSpan ts in freeTimes) {
                cobFreeTimes.Items.Add(ts);
            }

        }

        private void btnFinish_Click(object sender, EventArgs e) {
            //Skal laves om når der kommer et login på clienten indtil da en stub.
            if (cobNameER.Text.Equals("")) {
                cobNameER.BackColor = Color.Red;
                cobNameER.ForeColor = Color.White;
            }
            else if (txbUserName.Text.Equals("")) {
                txbUserName.BackColor = Color.Red;
            }
            else if (txbAmountOfPeople.Text.Equals("") || int.Parse(txbAmountOfPeople.Text) < 1) {
                txbAmountOfPeople.BackColor = Color.Red;
            }
            else if (cobFreeTimes.Text.Equals("")) {
                cobFreeTimes.BackColor = Color.Red;
                cobFreeTimes.ForeColor = Color.White;
            }

            else
            {
                Employee emp;
                emp = EmpCtr.Get(1);
               int c = BookCtr.Create(emp, Cus, EsR, TimeForBooking, AmountOfPeople, DateForBooking);
                if(c == 0) {             

                    cobFreeTimes.SelectedItem = null;
                    Freetimes();
                    lblErrorTime.Show();



                }
                else
                {

                    MainMenu mm = new MainMenu();
                        mm.Show();
                        this.Hide();
                }
            }
        }

        /// <summary>
        /// Hides the CreateBooking form and opens a new MainMenu(); (mm)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void cobFreeTimes_SelectedIndexChanged(object sender, EventArgs e) {
            bool found = false;
            int i = 0;
            cobFreeTimes.BackColor = Color.White;
            cobFreeTimes.ForeColor = Color.Black;
            lblErrorTime.Hide();
            while (i < freeTimes.Count && !found) {
                if (freeTimes.ElementAt(i).Equals(cobFreeTimes.SelectedItem)) {
                    TimeForBooking = freeTimes.ElementAt(i);
                    found = true;
                }
                else {
                    i++;
                }
            }
        }

        private void txbName_KeyDown(object sender, EventArgs e) {
            Cus = Cusctr.Get(txbUserName.Text);
            lblFirstNameRead.Text = Cus.FirstName;
            lblLastNameRead.Text = Cus.LastName;
            lblPhoneRead.Text = Cus.Phone;
            lblBookCustomerNameRead.Text = Cus.FirstName + Cus.LastName;
            txbUserName.BackColor = Color.White;
        }

        private void txbAmountOfPeople_Leave ( object sender, EventArgs e )
        {
            try { 
            if (txbAmountOfPeople.Text.Equals(""))
            {
                txbAmountOfPeople.BackColor = Color.Red;
            }
            else
            {
                txbAmountOfPeople.BackColor = Color.White;
                AmountOfPeople = int.Parse(txbAmountOfPeople.Text);
                lblErrorAOP.Visible = false;
            }                
            }
            catch {
                txbAmountOfPeople.Text  =  "";
                txbAmountOfPeople.BackColor = Color.Red;
            }
        }

        private void txbAmountOfPeople_TextChanged ( object sender, EventArgs e )
        {
            try {
                if (txbAmountOfPeople.Text.Equals("")) {
                }
                else {

                    int.Parse(txbAmountOfPeople.Text);
                    lblErrorAOP.Visible = false;
                }
            }
            catch (FormatException FE) {
                txbAmountOfPeople.Text = "";
                lblErrorAOP.Visible = true;
            }
        }

        private void txbUserName_TextChanged ( object sender, EventArgs e )
        {
            txbUserName.BackColor = Color.White;
        }
    }
}

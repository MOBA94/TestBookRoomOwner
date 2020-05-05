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
        }

        private void CreateBooking_Load() {
            escapeRooms = ERCtr.GetAllForOwner();
            cobNavnER.Items.Clear();

            foreach (EscapeRoom er in escapeRooms) {
                cobNavnER.Items.Add(er.Name);
            }
        }

        private void txbAmountOfPeople_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                int.Parse(txbAmountOfPeople.Text);
            }
            catch (FormatException FE) {
                Console.WriteLine(FE);
                Console.ReadLine();
                txbAmountOfPeople.ResetText();
                lblErrorAOP.Visible = true;
            }
        }

        private void cobNavnER_SelectedIndexChanged(object sender, EventArgs e) {
            bool found = false;
            int i = 0;
            EsR = new EscapeRoom();

            while (i < escapeRooms.Count && !found) {
                if (escapeRooms.ElementAt(i).Name.Equals(cobNavnER.SelectedItem)) {
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

            cmbFreeTimes.Items.Clear();
            freeTimes = ERCtr.FreeTimes(EsR.EscapeRoomID, DateForBooking);
            foreach (TimeSpan ts in freeTimes) {
                cmbFreeTimes.Items.Add(ts);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e) {
            //Skal laves om når der kommer et login på clienten indtil da en stub.
            
            Employee emp;
            emp = EmpCtr.Get(1);
            BookCtr.Create(emp, Cus, EsR, TimeForBooking, AmountOfPeople, DateForBooking);


            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void cmbFreeTimes_SelectedIndexChanged(object sender, EventArgs e) {
            bool found = false;
            int i = 0;

            while (i < freeTimes.Count && !found) {
                if (freeTimes.ElementAt(i).Equals(cmbFreeTimes.SelectedItem)) {
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
        }

        private void txbAmountOfPeople_Leave(object sender, EventArgs e) {
            AmountOfPeople = int.Parse(txbAmountOfPeople.Text);
            lblErrorAOP.Visible = false;
        }
    }
}

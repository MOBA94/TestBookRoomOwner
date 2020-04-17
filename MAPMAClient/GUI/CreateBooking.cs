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
        private DateTime TimeForBooking;
        private DateTime DateForBooking;


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

        private void txbAmountOfPeople_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter) {
                AmountOfPeople = int.Parse(txbAmountOfPeople.Text);
                lblErrorAOP.Visible = false;
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

        private void txbName_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter) {
                 Cus = Cusctr.Get(txbUserName.Text);
                lblFirstNameRead.Text = Cus.FirstName;
                lblLastNameRead.Text = Cus.LastName;
                lblPhoneRead.Text = Cus.Phone;
                lblBookCustomerNameRead.Text = Cus.FirstName + Cus.LastName;
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

        private void dtpBookTime_ValueChanged(object sender, EventArgs e) {
            TimeForBooking = dtpBookTime.Value;
        }

        private void calBookTime_DateChanged(object sender, DateRangeEventArgs e) {
            DateForBooking = calBookTime.SelectionRange.Start;
            string date = Convert.ToString(DateForBooking.ToShortDateString());
            lblBookDateRead.Text = date;
        }

        private void btnFinish_Click(object sender, EventArgs e) {
            //Skal laves om når der kommer et login på clienten indtil da en stub.
            Employee emp;
            emp = EmpCtr.Get(1);
            BookCtr.Create(emp, Cus, EsR, TimeForBooking, AmountOfPeople, DateForBooking);
        }
    }
}

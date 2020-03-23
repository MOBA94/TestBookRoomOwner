using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMA
{
    class Booking
    {
        private int amountOfPeople;
        private string cusName;
        private DateTime date;
        private DateTime bookingTime;
        private EscapeRoom er;
        private Customer cus;
        private Employee emp;

        public Booking(int amountOfPeople, DateTime date, DateTime bookingTime)
        {
            this.AmountOfPeople = amountOfPeople;
            this.Date = date;
            this.BookingTime = bookingTime;
        }

        public int AmountOfPeople { get => amountOfPeople; set => amountOfPeople = value; }
        public string CusName { get => cusName; set => cusName = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime BookingTime { get => bookingTime; set => bookingTime = value; }
        public EscapeRoom Er { get => er; set => er = value; }
        public Customer Cus { get => cus; set => cus = value; }
        public Employee Emp { get => emp; set => emp = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMA
{
    class Booking
    {
        public int amountOfPeople { get => amountOfPeople; set => amountOfPeople = value; }
        public string cusName { get => cusName; set => cusName = value; }
        public DateTime date { get => date; set => date = value; }
        public DateTime bookingTime { get => bookingTime; set => bookingTime = value; }
        public EscapeRoom er { get => er; set => er = value; }
        public Customer cus { get => cus; set => cus = value; }
        public Employee emp { get => emp; set => emp = value; }

        public Booking(int amountOfPeople, DateTime date, DateTime bookingTime)
        {
            this.amountOfPeople = amountOfPeople;
            this.date = date;
            this.bookingTime = bookingTime;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Model {
    public class Booking {

        public int AmountOfPeople {
            get; set;
        }
        public DateTime Date {
            get; set;
        }
        public TimeSpan BookingTime {
            get; set;
        }
        public EscapeRoom Er {
            get; set;
        }
        public Customer Cus {
            get; set;
        }
        public Employee Emp {
            get; set;
        }
        public int Id {
            get; set;
        }

        public Booking(int amountOfPeople, DateTime date, TimeSpan bookingTime) {
            this.AmountOfPeople = amountOfPeople;
            this.Date = date;
            this.BookingTime = bookingTime;
        }

        public Booking(int amountOfPeople, DateTime date, TimeSpan bookingTime, Customer cus, EscapeRoom er) {
            this.AmountOfPeople = amountOfPeople;
            this.Date = date;
            this.BookingTime = bookingTime;
            this.Cus = cus;
            this.Er = er;

        }

        public Booking(int amountOfPeople, DateTime date, TimeSpan bookingTime, Employee emp, EscapeRoom er) {
            this.AmountOfPeople = amountOfPeople;
            this.Date = date;
            this.BookingTime = bookingTime;
            this.Emp = emp;
            this.Er = er;
        }

        public Booking() {

        }
    }

}
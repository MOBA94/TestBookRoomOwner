using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Model {
    /// <summary>
    /// <author>
    /// Mick O. B. Andersen
    /// Anders S. Brygger
    /// Peter S. Clausen
    /// Anders B. Larsen
    /// Mads G. Ranzau
    /// </author>
    /// </summary>
    public class Booking {

        /// <summary>
        /// Get and set for AmountOfPeople
        /// </summary>
        public int AmountOfPeople {
            get; set;
        }

        /// <summary>
        /// Get and set for Date
        /// </summary>
        public DateTime Date { 
            get; set;
        }

        /// <summary>
        /// Get and set for BookingTime
        /// </summary>
        public TimeSpan BookingTime {
            get; set;
        }

        /// <summary>
        /// Get and set for EscapeRoom (Er)
        /// </summary>
        public EscapeRoom Er {
            get; set;
        }

        /// <summary>
        /// Get and set for Customer (Cus)
        /// </summary>
        public Customer Cus {
            get; set;
        }

        /// <summary>
        /// Get and set for Employee (Emp)
        /// </summary>
        public Employee Emp {
            get; set;
        }

        /// <summary>
        /// Get and set for Id
        /// </summary>
        public int Id {
            get; set;
        }

        /// <summary>
        /// Constuctor for Booking with the following parameters
        /// </summary>
        /// <param name="amountOfPeople"></param>
        /// <param name="date"></param>
        /// <param name="bookingTime"></param>
        public Booking(int amountOfPeople, DateTime date, TimeSpan bookingTime) {
            this.AmountOfPeople = amountOfPeople;
            this.Date = date;
            this.BookingTime = bookingTime;
        }

        /// <summary>
        /// Constuctor for Booking with the following parameters
        /// </summary>
        /// <param name="amountOfPeople"></param>
        /// <param name="date"></param>
        /// <param name="bookingTime"></param>
        /// <param name="cus"></param>
        /// <param name="er"></param>
        public Booking(int amountOfPeople, DateTime date, TimeSpan bookingTime, Customer cus, EscapeRoom er) {
            this.AmountOfPeople = amountOfPeople;
            this.Date = date;
            this.BookingTime = bookingTime;
            this.Cus = cus;
            this.Er = er;

        }

        /// <summary>
        /// Constuctor for Booking with the following parameters
        /// </summary>
        /// <param name="amountOfPeople"></param>
        /// <param name="date"></param>
        /// <param name="bookingTime"></param>
        /// <param name="emp"></param>
        /// <param name="er"></param>
        public Booking(int amountOfPeople, DateTime date, TimeSpan bookingTime, Employee emp, EscapeRoom er) {
            this.AmountOfPeople = amountOfPeople;
            this.Date = date;
            this.BookingTime = bookingTime;
            this.Emp = emp;
            this.Er = er;
        }

        /// <summary>
        /// Empty constructor for Booking
        /// </summary>
        public Booking() {

        }
    }

}
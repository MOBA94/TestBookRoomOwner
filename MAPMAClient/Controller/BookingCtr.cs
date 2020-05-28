using MAPMAClient.Model;
using MAPMAClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Controller {
    /// <summary>
    /// <author>
    /// Mick O. B. Andersen
    /// Anders S. Brygger
    /// Peter S. Clausen
    /// Anders B. Larsen
    /// Mads G. Ranzau
    /// </author>
    /// </summary>
    public class BookingCtr {

        private BookServices BOOKS;

        /// <summary>
        /// Makes a new BookingServices named BOOKS
        /// </summary>
        public BookingCtr() {
            BOOKS = new BookServices();
        }

        /// <summary>
        /// Creates a booking and saves it in the database
        /// </summary>
        /// <param name="Emp"></param>
        /// <param name="Cus"></param>
        /// <param name="ER"></param>
        /// <param name="BookingTime"></param>
        /// <param name="AmountOfPeople"></param>
        /// <param name="Date"></param>
        /// <returns> The booking just made (book) </returns>
        public int Create(Employee Emp, Customer Cus, EscapeRoom ER, TimeSpan BookingTime, int AmountOfPeople, DateTime Date) {

            Booking book = new Booking() {
                AmountOfPeople = AmountOfPeople,
                BookingTime = BookingTime,
                Cus = Cus,
                Date = Date,
                Emp = Emp,
                Er = ER

            };

           return BOOKS.Create(book);
        }

        /// <summary>
        /// Deletes a booking from the database
        /// </summary>
        /// <param name="cus"></param>
        /// <param name="esr"></param>
        /// <param name="date"></param>
        /// <param name="emp"></param>
        /// <param name="aop"></param>
        /// <param name="bookTime"></param>
        public void Delete(Customer cus, EscapeRoom esr, DateTime date, Employee emp, int aop, TimeSpan bookTime) {
            Booking book = new Booking() {
                Cus = cus,
                Er = esr,
                Date = date,
                Emp = emp,
                AmountOfPeople = aop,
                BookingTime = bookTime
            };

            BOOKS.Delete(book);
        }

        /// <summary>
        /// Updates a booking and saves it in the database
        /// </summary>
        /// <param name="cus"></param>
        /// <param name="esr"></param>
        /// <param name="date"></param>
        /// <param name="emp"></param>
        /// <param name="aop"></param>
        /// <param name="bookTime"></param>
        /// <param name="id"></param>
        public void Update(Customer cus, EscapeRoom esr, DateTime date, Employee emp, int aop, TimeSpan bookTime, int id)
        {
            Booking book = new Booking()
            {
                AmountOfPeople = aop,
                BookingTime = bookTime,
                Cus = cus,
                Date = date,
                Emp = emp,
                Er = esr,
                Id = id
            };
            BOOKS.Update(book);
        }

        /// <summary>
        /// Gets a booking from the database
        /// </summary>
        /// <param name="cus"></param>
        /// <param name="esr"></param>
        /// <param name="date"></param>
        /// <returns> A booking </returns>
        public Booking Get(Customer cus, EscapeRoom esr, DateTime date) {
            return BOOKS.Get(cus, esr, date);
        }

        /// <summary>
        /// Gets all the bookings in the database
        /// </summary>
        /// <returns> A list of all the bookings </returns>
        public List<Model.Booking> GetAll() {
            return BOOKS.GetAll();
        }

        /// <summary>
        /// Gets all the bookings from one escaperoom
        /// </summary>
        /// <param name="EscId"></param>
        /// <returns> A list of all the bookings from one escaperoom </returns>
        public List<Model.Booking> GetAllOneRoom(int EscId) {
            return BOOKS.GetAllOneRoom(EscId);
        }

    }
}

using MAPMAClient.Model;
using MAPMAClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Controller {
    class BookingCtr {

        private BookServices BOOKS;

        public BookingCtr() {
            BOOKS = new BookServices();
        }

        public void Create(Employee Emp, Customer Cus, EscapeRoom ER, DateTime BookingTime, int AmountOfPeople, DateTime Date) {

            Booking book = new Booking() {
                AmountOfPeople = AmountOfPeople,
                BookingTime = BookingTime,
                Cus = Cus,
                Date = Date,
                Emp = Emp,
                Er = ER

            };

            BOOKS.Create(book);
        }
    }
}

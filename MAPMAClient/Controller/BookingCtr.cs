﻿using MAPMAClient.Model;
using MAPMAClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Controller {
    public class BookingCtr {

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

        public void Delete(Customer cus, EscapeRoom esr, DateTime date) {
            Booking book = new Booking() {
                Cus = cus,
                Er = esr,
                Date = date
            };

            BOOKS.Delete(book);
        }

        public Booking Get(Customer cus, EscapeRoom esr, DateTime date) {
            return BOOKS.Get(cus, esr, date);
        }
    }
}
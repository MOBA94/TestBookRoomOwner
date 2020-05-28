using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAPMAClient.Controller;
using MAPMAClient.Model;

namespace TestBookRoomOwner
{
    [TestClass]
    public class TestUpdateBooking
    {
        [TestMethod]

        public void TestMethod1 ( )
        {
            //Arrange
            BookingCtr bc = new BookingCtr();
            CustomerCtr cc = new CustomerCtr();
            EscapeRoomCtr esrCtr = new EscapeRoomCtr();
            EmployeeCtr empCtr = new EmployeeCtr();
            EscapeRoom Er = esrCtr.GetForOwner(2);
            Customer cus = cc.Get("Anorak");
            Employee em = empCtr.Get(1);
            TimeSpan bookTime = new TimeSpan(16,00,00);
            Booking book = new Booking(){
               AmountOfPeople = 10,
               BookingTime = bookTime,
               Cus = cus,
               Date = DateTime.Now.AddDays(7.0).Date,
               Emp = em,
               Er = Er
            };

            //Act
            bc.Create(book.Emp, book.Cus, book.Er, book.BookingTime, book.AmountOfPeople, book.Date);
            Booking TestBook = bc.Get(cus, Er, book.Date);
            bc.Update(book.Cus, book.Er, book.Date, book.Emp, 100, book.BookingTime, TestBook.Id);
            TestBook = bc.Get(cus, Er, book.Date);

            //Assert
            Assert.AreEqual(book.Er.Name, TestBook.Er.Name);
            Assert.AreNotEqual(book.AmountOfPeople,TestBook.AmountOfPeople );

            bc.Delete(cus, Er, book.Date, em, TestBook.AmountOfPeople, TestBook.BookingTime);
        }
    }
}
